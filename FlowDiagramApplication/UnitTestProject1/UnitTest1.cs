using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FlowDiagramApplication.Components;
using System.Drawing;
using FlowDiagramApplication;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateFlowSimple()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component c = fl.Components[0];
            fl.ChangeCapacity(c, 25);
            fl.ChangeCurrentFlow(c, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component c2 = fl.Components[1];
            fl.Connect(c2, c, null, null);
            double flow = fl.CalculateFlow();
            Assert.AreEqual(flow, 20);
        }
        [TestMethod]
        public void TestSetPumpFlowMoreThanCapacity()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component c = fl.Components[0];
            fl.ChangeCapacity(c, 25);
            fl.ChangeCurrentFlow(c, 40);
            Assert.AreEqual(((Pump)c).Output, 0);
        }
        [TestMethod]
        public void TestCalculateFlowWithMerger()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component p = fl.Components[0];
            Component p1 = fl.Components[1];
            fl.ChangeCapacity(p, 25);
            fl.ChangeCurrentFlow(p, 20);
            fl.ChangeCapacity(p1, 25);
            fl.ChangeCurrentFlow(p1, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Merger);
            Component m = fl.Components[2];
            fl.Connect(m, p, "up", null);
            fl.Connect(m, p1, "down", null);
            Assert.IsTrue(((Merger)m).LowerConnectedComponent == p1.GetId());
            Assert.IsTrue(((Merger)m).UpperConnectedComponent == p.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component s = fl.Components[3];
            fl.Connect(s, m, null, null);
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pomp = fl.Components[4];
            Component sink = fl.Components[5];
            fl.ChangeCapacity(pomp, 25);
            fl.ChangeCurrentFlow(pomp, 20);
            fl.Connect(sink, pomp, null, null);
            double flow = fl.CalculateFlow();
            Assert.AreEqual(flow, 60);
        }
        [TestMethod]
        public void TestCalculateFlowWithAdjustableSplitter()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component p = fl.Components[0];
            fl.ChangeCapacity(p, 25);
            fl.ChangeCurrentFlow(p, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            Component ads = fl.Components[1];
            fl.Connect(ads, p, null, null);
            Assert.IsTrue(((AdjustableSplitter)ads).OtherConnected == p.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component s = fl.Components[2];
            fl.Connect(s, ads, null, "up");
            Assert.IsTrue(((AdjustableSplitter)ads).UpperConnectedComponent == s.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component sink = fl.Components[3];
            fl.Connect(sink, ads, null, "down");
            Assert.IsTrue(((AdjustableSplitter)ads).LowerConnectedComponent == sink.GetId());
            double flow = fl.CalculateFlow();
            Assert.AreEqual(flow, 20);
            Assert.AreEqual(((Sink)s).Input, 14);
            Assert.AreEqual(((Sink)sink).Input, 6);
        }
        [TestMethod]
        public void TestCalculateFlowWithAdjustableSplitterHalfConnected()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component p = fl.Components[0];
            fl.ChangeCapacity(p, 25);
            fl.ChangeCurrentFlow(p, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            Component ads = fl.Components[1];
            fl.Connect(ads, p, null, null);
            Assert.IsTrue(((AdjustableSplitter)ads).OtherConnected == p.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component s = fl.Components[2];
            fl.Connect(s, ads, null, "up");
            Assert.IsTrue(((AdjustableSplitter)ads).UpperConnectedComponent == s.GetId());
            double flow = fl.CalculateFlow();
            Assert.AreEqual(flow, 14);
            Assert.AreEqual(((Sink)s).Input, 14);
        }
        [TestMethod]
        public void TestCalculateFlowWithSplitter()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component p = fl.Components[0];
            fl.ChangeCapacity(p, 25);
            fl.ChangeCurrentFlow(p, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            Component sp = fl.Components[1];
            fl.Connect(sp, p, null, null);
            Assert.IsTrue(((Splitter)sp).OtherConnected == p.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component s = fl.Components[2];
            fl.Connect(s, sp, null, "up");
            Assert.IsTrue(((Splitter)sp).UpperConnectedComponent == s.GetId());
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component sink = fl.Components[3];
            fl.Connect(sink, sp, null, "down");
            Assert.IsTrue(((Splitter)sp).LowerConnectedComponent == sink.GetId());
            double flow = fl.CalculateFlow();
            Assert.AreEqual(flow, 20);
            Assert.AreEqual(((Sink)s).Input, 10);
            Assert.AreEqual(((Sink)sink).Input, 10);
        }
        [TestMethod]
        public void TestCalculateFlowWithNestedSplitters()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component ads1 = fl.Components[1];
            Component sp = fl.Components[2];
            Component ads2 = fl.Components[3];
            Component sink1 = fl.Components[4];
            Component sink2 = fl.Components[5];
            Component sink3 = fl.Components[6];
            Component sink4 = fl.Components[7];
            fl.ChangeCapacity(pump, 50);
            fl.ChangeCurrentFlow(pump, 50);
            fl.Connect(ads1, pump, null, null);
            fl.Connect(sp, ads1, null, "up");
            fl.Connect(ads2, ads1, null, "down");
            fl.Connect(sink1, sp, null, "up");
            fl.Connect(sink2, sp, null, "down");
            fl.Connect(sink3, ads2, null, "up");
            fl.Connect(sink4, ads2, null, "down");
            double flow = fl.CalculateFlow();
            Assert.AreEqual(((Sink)sink1).Input, 17.5);
            Assert.AreEqual(((Sink)sink2).Input, 17.5);
            Assert.AreEqual(((Sink)sink3).Input, 10.5);
            Assert.AreEqual(((Sink)sink4).Input, 4.5);
            Assert.AreEqual(flow, 50);
        }

        [TestMethod]
        public void TestAddTwoSameConnections()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component sink = fl.Components[1];
            fl.ChangeCapacity(pump, 25);
            fl.ChangeCurrentFlow(pump, 50);
            fl.Connect(sink, pump, null, null);
            fl.Connect(sink, pump, null, null);
            Assert.AreEqual(fl.Connections.Count, 1);
        }

        [TestMethod]
        public void TestConnectSplitter()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component splitter = fl.Components[0];
            Component sink = fl.Components[1];
            fl.Connect(sink, splitter, null, "up");
            Assert.AreEqual(fl.Connections.Count, 1);
            fl.Connect(sink, splitter, null, "down");
            Assert.AreEqual(fl.Connections.Count, 2);
        }

        [TestMethod]
        public void TestPipelineColor()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component sink = fl.Components[1];
            fl.ChangeCapacity(pump, 200);
            fl.ChangeCurrentFlow(pump, 199);
            fl.Connect(sink, pump, null, null);
            fl.CalculateFlow();
            //red...
            Assert.AreEqual(fl.Connections[0].CheckColor(), 3);
            fl.ChangeCurrentFlow(pump, 95);
            fl.CalculateFlow();
            //yellow..
            Assert.AreEqual(fl.Connections[0].CheckColor(), 2);
        }

        [TestMethod]
        public void TestDeleteComponent()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component ads1 = fl.Components[1];
            Component sp = fl.Components[2];
            Component ads2 = fl.Components[3];
            Component sink1 = fl.Components[4];
            Component sink2 = fl.Components[5];
            Component sink3 = fl.Components[6];
            Component sink4 = fl.Components[7];
            fl.ChangeCapacity(pump, 25);
            fl.ChangeCurrentFlow(pump, 50);
            fl.Connect(ads1, pump, null, null);
            fl.Connect(sp, ads1, null, "up");
            fl.Connect(ads2, ads1, null, "down");
            fl.Connect(sink1, sp, null, "up");
            fl.Connect(sink2, sp, null, "down");
            fl.Connect(sink3, ads2, null, "up");
            fl.Connect(sink4, ads2, null, "down");
            fl.DeleteComponent(ads1);
            Assert.AreEqual(fl.Connections.Count, 4);
        }
        [TestMethod]
        public void TestAddComponent()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component ads1 = fl.Components[1];
            Component sp = fl.Components[2];
            Component ads2 = fl.Components[3];
            Component sink1 = fl.Components[4];
            Component sink2 = fl.Components[5];
            Component sink3 = fl.Components[6];
            Component sink4 = fl.Components[7];
            Assert.AreEqual(fl.Components.Count, 8);
        }
        [TestMethod]
        public void TestClearDiagram()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Splitter);
            fl.AddComponent(new Point(1, 1), ComponentType.AdjustableSplitter);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component pump = fl.Components[0];
            Component ads1 = fl.Components[1];
            Component sp = fl.Components[2];
            Component ads2 = fl.Components[3];
            Component sink1 = fl.Components[4];
            Component sink2 = fl.Components[5];
            Component sink3 = fl.Components[6];
            Component sink4 = fl.Components[7];
            fl.ChangeSafetyLimitGeneral(200);
            fl.ClearFlowDiagram();
            Assert.AreEqual(fl.Components.Count, 0);
            Assert.AreEqual(fl.Connections.Count, 0);
            Assert.AreEqual(fl.GeneralSafetyLimit, 200);
        }
        [TestMethod]
        public void TestChangePipeSafetyLimit()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component c = fl.Components[0];
            fl.ChangeCapacity(c, 25);
            fl.ChangeCurrentFlow(c, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component c2 = fl.Components[1];
            fl.Connect(c2, c, null, null);
            fl.ChangeSafetyLimit(160, fl.Connections[0]);
            Assert.AreEqual(fl.Connections[0].SafetyLimit, 160);
        }
        [TestMethod]
        public void TestChangeGeneralSafetyLimit()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.ChangeSafetyLimitGeneral(120);
            Assert.AreEqual(fl.GeneralSafetyLimit, 120);
        }
        [TestMethod]
        public void TestMakeConnection()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component c = fl.Components[0];
            fl.ChangeCapacity(c, 25);
            fl.ChangeCurrentFlow(c, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component c2 = fl.Components[1];
            fl.Connect(c2, c, null, null);
            Assert.AreEqual(fl.Connections.Count, 1);
            Assert.IsTrue(fl.Connections[0].InputElement == c2);
            Assert.IsTrue(fl.Connections[0].OutputElement == c);
        }
        [TestMethod]
        public void TestSaveToFile()
        {
            FlowDiagram fl = new FlowDiagram();
            fl.AddComponent(new Point(1, 1), ComponentType.Pump);
            Component c = fl.Components[0];
            fl.ChangeCapacity(c, 25);
            fl.ChangeCurrentFlow(c, 20);
            fl.AddComponent(new Point(1, 1), ComponentType.Sink);
            Component c2 = fl.Components[1];
            fl.Connect(c2, c, null, null);
            string pathNew = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
            "\\test.bin";
            fl.SaveToFile(pathNew);
            Assert.IsTrue(File.Exists(pathNew));
        }
        [TestMethod]
        public void TestLoadFromFile()
        {
            string pathNew = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
            "\\test.bin";
            FlowDiagram fl = new FlowDiagram();
            fl.LoadFromFile(pathNew);
            Assert.IsTrue(fl.Components.Count == 2);
            Assert.IsTrue(fl.Connections.Count == 1);
        }
    }
}
