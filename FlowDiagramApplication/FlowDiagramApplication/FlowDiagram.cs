using FlowDiagramApplication.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// This is the main class that executes the logic of the flow diagram application.
    /// Created by Dimitar and Lyubomir
    /// </summary>
    public class FlowDiagram
    {
        /// <summary>
        /// Dimitar
        /// </summary>
        /// <param name="c"></param>
        private void MakeFlowFromComponent(Component c)
        {
            switch (c.ComponentType)
            {
                case ComponentType.AdjustableSplitter:
                    double coming = 0;
                    var comingFound = this.Connections
                                    .Where(x => x.InputElement.GetId() == c.GetId())
                                    .Select(x => x.CurrentFlow);
                    if (comingFound.Any() == true)
                    {
                        coming = comingFound.First();
                    }
                    if (((AdjustableSplitter)c).UpperConnectedComponent != 0)
                    {
                        var connectionsAds = this.Connections
                            .Where(x => x.InputElement.GetId() == ((AdjustableSplitter)c).UpperConnectedComponent)
                            .Select(x => x);
                        Pipeline connectionAds = null;
                        if (connectionsAds.Any() == true)
                        {
                            connectionAds = connectionsAds.First();
                        }
                        if (connectionAds != null)
                        {
                            double flowToSet = (((AdjustableSplitter)c).DivisionRate * coming) / 100;
                            connectionAds.SetFlow(flowToSet);
                            Component nextComponent = connectionAds.InputElement;
                            this.MakeFlowFromComponent(nextComponent);
                        }
                    }
                    if (((AdjustableSplitter)c).LowerConnectedComponent != 0)
                    {
                        var connectionsAdsLower = this.Connections
                        .Where(x => x.InputElement.GetId() == ((AdjustableSplitter)c).LowerConnectedComponent)
                        .Select(x => x);
                        Pipeline connectionAdsLower = null;
                        if (connectionsAdsLower.Any() == true)
                        {
                            connectionAdsLower = connectionsAdsLower.First();
                        }
                        if (connectionAdsLower != null)
                        {
                            double flowToSet2 = ((100 - ((AdjustableSplitter)c).DivisionRate) * coming) / 100;
                            connectionAdsLower.SetFlow(flowToSet2);
                            Component nextComponent = connectionAdsLower.InputElement;
                            this.MakeFlowFromComponent(nextComponent);
                        }
                    }
                    break;
                case ComponentType.Merger:
                    double comingUpper = 0;
                    double comingLower = 0;
                    var comingUpperfound = this.Connections
                    .Where(x => x.OutputElement.GetId() == ((Merger)c).UpperConnectedComponent)
                    .Select(x => x.CurrentFlow);
                    if (comingUpperfound.Any() == true)
                    {
                        comingUpper = comingUpperfound.First();
                    }
                    var comingLowerfound = this.Connections
                    .Where(x => x.OutputElement.GetId() == ((Merger)c).LowerConnectedComponent)
                    .Select(x => x.CurrentFlow);
                    if (comingLowerfound.Any() == true)
                    {
                        comingLower = comingLowerfound.First();
                    }
                    Pipeline connectionFoundMerger = null;
                    var connectionsFoundMerger = this.Connections
                        .Where(x => x.OutputElement.GetId() == c.GetId())
                        .Select(x => x);
                    if (connectionsFoundMerger.Any() == true)
                    {
                        connectionFoundMerger = connectionsFoundMerger.First();
                    }
                    if (connectionFoundMerger != null)
                    {
                        connectionFoundMerger.SetFlow(comingLower + comingUpper);
                        Component nextComponent = connectionFoundMerger.InputElement;
                        this.MakeFlowFromComponent(nextComponent);
                    }
                    break;
                case ComponentType.Pump:
                    Pipeline connectionFound = null;
                    var connectionsFound = this.Connections
                        .Where(x => x.OutputElement.GetId() == c.GetId())
                        .Select(x => x);
                    if (connectionsFound.Any() == true)
                    {
                        connectionFound = connectionsFound.First();
                    }
                    if (connectionFound != null)
                    {
                        connectionFound.SetFlow(((Pump)c).Output);
                        Component nextComponent = connectionFound.InputElement;
                        this.MakeFlowFromComponent(nextComponent);
                    }
                    break;
                case ComponentType.Sink:
                    Pipeline connectionFound2 = null;
                    var connectionsFound2 = this.Connections
                        .Where(x => x.InputElement.GetId() == c.GetId())
                        .Select(x => x);
                    if (connectionsFound2.Any())
                    {
                        connectionFound2 = connectionsFound2.First();
                        ((Sink)c).SetInput(connectionFound2.CurrentFlow);
                    }
                    else
                    {
                        ((Sink)c).SetInput(0);
                    }
                    break;
                case ComponentType.Splitter:
                    double comingToSpliter = this.Connections
                                    .Where(x => x.InputElement.GetId() == c.GetId())
                                    .Select(x => x.CurrentFlow).First();
                    if (((Splitter)c).UpperConnectedComponent != 0)
                    {
                        var connectionsAds = this.Connections
                            .Where(x => x.InputElement.GetId() == ((Splitter)c).UpperConnectedComponent)
                            .Select(x => x);
                        Pipeline connectionAds = null;
                        if (connectionsAds.Any() == true)
                        {
                            connectionAds = connectionsAds.First();
                        }
                        if (connectionAds != null)
                        {
                            double flowToSet = comingToSpliter / 2;
                            connectionAds.SetFlow(flowToSet);
                            Component nextComponent = connectionAds.InputElement;
                            this.MakeFlowFromComponent(nextComponent);
                        }
                    }
                    if (((Splitter)c).LowerConnectedComponent != 0)
                    {
                        var connectionsAdsLower = this.Connections
                        .Where(x => x.InputElement.GetId() == ((Splitter)c).LowerConnectedComponent)
                        .Select(x => x);
                        Pipeline connectionAdsLower = null;
                        if (connectionsAdsLower.Any() == true)
                        {
                            connectionAdsLower = connectionsAdsLower.First();
                        }
                        if (connectionAdsLower != null)
                        {
                            double flowToSet2 = comingToSpliter / 2;
                            connectionAdsLower.SetFlow(flowToSet2);
                            Component nextComponent = connectionAdsLower.InputElement;
                            this.MakeFlowFromComponent(nextComponent);
                        }
                    }
                    break;
                default:
                    throw new Exception("not a valid component type");
            }
        }
        /// <summary>
        /// The constructor of the class.
        /// </summary>
        public FlowDiagram()
        {
            this.Components = new List<Component>();
            this.Connections = new List<Pipeline>();
            this.totalFlow = 0;
            this.generalSafetyLimit =100;
        }

        /// <summary>
        /// The list of all the components in the flow diagram.
        /// </summary>
        public List<Component> Components;

        /// <summary>
        /// The list of all the connections in the flow diagram.
        /// </summary>
        public List<Pipeline> Connections;

        /// <summary>
        /// The total flow in the flow diagram.
        /// </summary>
        private double totalFlow;

        /// <summary>
        /// The general safety limit in the flow diagram.
        /// </summary>
        private double generalSafetyLimit;
        public double GeneralSafetyLimit
        {
            get { return this.generalSafetyLimit; }
        }

        /// <summary>
        /// The method that calculates the current flow in the flow diagram.
        /// </summary>
        /// <returns>The current flow in the flow diagram as a double</returns>
        public double CalculateFlow()
        {
            totalFlow = 0;
            foreach(Pipeline p in this.Connections)
            {
                p.SetFlow(0);
            }
            List<Pipeline> pipesFromPumps = this.Connections
                .Where(x => x.OutputElement.ComponentType == ComponentType.Pump).ToList();
            foreach (Pipeline p in pipesFromPumps)
            {
                //p.SetFlow(((Pump)p.OutputElement).Output);
                this.MakeFlowFromComponent(p.OutputElement);
            }
            List<Component> sinks = this.Components
                .Where(x => x.ComponentType == ComponentType.Sink)
                .ToList();
            foreach (Component s in sinks)
            {
                this.MakeFlowFromComponent(s);
                totalFlow = totalFlow + ((Sink)s).Input;
            }
            return totalFlow;
        }
        /// <summary>
        /// Dimitar 
        /// </summary>
        /// <param name="componentId"></param>
        /// <returns></returns>
        public Component GetComponentById(int componentId)
        {
            Component found = null;
            foreach (Component component in this.Components)
            {
                if (component.GetId() == componentId)
                {
                    found = component;
                }
            }
            return found;
        }

        /// <summary>
        /// Dimitar
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public Pipeline GetPipelineByTwoComponents(Component first, Component second)
        {
            Pipeline found = null;
            foreach (Pipeline pipe in this.Connections)
            {
                if ((pipe.OutputElement.GetId() == first.GetId())&&(pipe.InputElement.GetId() == second.GetId()))
                {
                    found = pipe;
                }
            }
            return found;
        }

        /// <summary>
        /// The method that clears the flow diagram from the drawing space.
        /// Created by: Dimitar
        /// </summary>
        public void ClearFlowDiagram()
        {
            this.Components.Clear();
            this.Connections.Clear();
            this.totalFlow = 0;
        }

        /// <summary>
        /// The method that serializes the flow diagram and saves it to a file.
        /// Lyubomir
        /// </summary>
        /// <param name="filename">The name of the file that is to be saved.</param>
        public void SaveToFile(string filename)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, Components);
                bf.Serialize(fs, Connections);
                bf.Serialize(fs, generalSafetyLimit);
                bf.Serialize(fs, totalFlow);
            }
            catch (SerializationException)
            { throw new Exception("something wrong with Serialization"); }
            catch (IOException)
            { throw new Exception("something wrong with IO"); }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        /// <summary>
        /// The method that loads a file and deserializes a flow diagram from it. 
        /// Lyubomir
        /// </summary>
        /// <param name="filename">The file that is to be loaded.</param>
        public void LoadFromFile(string filename)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();

                Components = (List<Component>)(bf.Deserialize(fs));
                Connections = (List<Pipeline>)(bf.Deserialize(fs));
                generalSafetyLimit = (double)(bf.Deserialize(fs));
                totalFlow = (double)(bf.Deserialize(fs));

                //listBox1.Items.Add(t.ToString());
                //for next example: C&P from below

            }
            catch (SerializationException)
            { throw new Exception("something wrong with Serialization"); }
            catch (IOException)
            { throw new Exception("something wrong with IO"); }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        /// <summary>
        /// The method that adds a component to the list with components.
        /// Lyubomir
        /// </summary>
        /// <param name="position">The position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public void AddComponent(Point position, ComponentType type)
        {
            switch (type)
            {
                case ComponentType.AdjustableSplitter:
                    this.Components.Add(new AdjustableSplitter(position, type));
                    break;
                case ComponentType.Merger:
                    this.Components.Add(new Merger(position, type));
                    break;
                case ComponentType.Pump:
                    this.Components.Add(new Pump(position, type));
                    break;
                case ComponentType.Sink:
                    this.Components.Add(new Sink(position, type));
                    break;
                case ComponentType.Splitter:
                    this.Components.Add(new Splitter(position, type));
                    break;
                default:
                    throw new Exception("not a valid component type was selected");
            }
        }

        /// <summary>
        /// The method that is deleting a component from the list of components.
        /// Dimitar
        /// </summary>
        /// <param name="component">The component that is to be deleted.</param>
        public bool DeleteComponent(Component component)
        {
            var componentFound = this.Components
                .Where(x => x.GetId() == component.GetId())
                .Select(x => x).First();
            for (int i = 0; i < this.Components.Count; i++)
            {
                if (this.Components.ElementAt(i).GetId() == componentFound.GetId())
                {
                    this.Components.RemoveAt(i);
                    int numberOfConnections = this.Connections
                        .Where(x => x.InputElement.GetId() == componentFound.GetId())
                        .Select(x => x).Count() +
                        this.Connections
                        .Where(x => x.OutputElement.GetId() == componentFound.GetId())
                        .Select(x => x).Count();
                    for(int p=1; p<=numberOfConnections; p++)
                    {
                        for (int l = 0; l < this.Connections.Count; l++)
                        {
                            if ((this.Connections.ElementAt(l).InputElement.GetId() == componentFound.GetId()) ||
                                (this.Connections.ElementAt(l).OutputElement.GetId() == componentFound.GetId()))
                            {
                                this.Connections.RemoveAt(l);
                            }
                        }
                    }
                    this.CalculateFlow();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// The method that changes the position of a component.
        /// Dimitar
        /// </summary>
        /// <param name="position">The new position for the component</param>
        /// <param name="component">The component that is going to have its 
        /// position changed.</param>
        public void ChangeComponentPosition(Point position, Component component)
        {
            var componentFound = this.Components
            .Where(x => x.GetId() == component.GetId())
            .Select(x => x).First();
            if (componentFound != null)
            {
                componentFound.ChangePosition(position);
            }
            else
            {
                throw new Exception("this component was not found in the list of components...");
            }
        }

        /// <summary>
        /// The method that makes a connection between two components.
        /// Dimitar
        /// </summary>
        /// <param name="connectTo">The second component that is to be connected.</param>
        /// <param name="connectFrom">The first component that is to be connected.</param>
        public void Connect(Component connectTo, Component connectFrom, string  inputPosition, string outputPosition)
        {
                Pipeline pipe = new Pipeline(connectTo, connectFrom);
                if ((connectTo.ComponentType == ComponentType.Pump) || (connectFrom.ComponentType == ComponentType.Sink))
                {
                pipe = new Pipeline(connectFrom, connectTo);
                }
            var connectionsFound = this.Connections
                    .Where(x => x.InputElement.GetId() == connectTo.GetId())
                    .Where(x => x.OutputElement.GetId() == connectFrom.GetId())
                    .ToList();
                if (connectionsFound.Count != 0)
                {
                    if(connectTo.ComponentType == ComponentType.Merger)
                    {
                            if (connectionsFound.Count() > 1)
                            {
                                return;
                            }
                            if((inputPosition == "down") && (((Merger)connectTo).LowerConnectedComponent != 0))
                            {
                                return;
                            }
                            if ((inputPosition == "up") && (((Merger)connectTo).UpperConnectedComponent != 0))
                            {
                                return;
                            }
                }
                    if ((connectFrom.ComponentType == ComponentType.Splitter)||(connectFrom.ComponentType == ComponentType.AdjustableSplitter))
                    {
                        if (connectionsFound.Count() > 1)
                        {
                            return;
                        }
                        if ((outputPosition == "down") && (((MiddleComponent)connectFrom).LowerConnectedComponent != 0))
                        {
                            return;
                        }
                        if ((outputPosition == "up") && (((MiddleComponent)connectFrom).UpperConnectedComponent != 0))
                        {
                            return;
                        }
                }
                else
                    {
                        return;
                    }
                }
                this.Connections.Add(pipe);
                if ((inputPosition != null)&&(inputPosition != String.Empty))
                {
                    if (inputPosition == "up")
                    {
                        ((MiddleComponent)connectTo).ConnectUpper(connectFrom);
                    }
                    else
                    {
                        ((MiddleComponent)connectTo).ConnectLower(connectFrom);
                    }
                }
                if ((outputPosition != null) && (outputPosition != String.Empty))
                {
                    if (outputPosition == "up")
                    {
                        ((MiddleComponent)connectFrom).ConnectUpper(connectTo);
                    }
                    else
                    {
                        ((MiddleComponent)connectFrom).ConnectLower(connectTo);
                    }
                }
                if (((connectTo.ComponentType == ComponentType.AdjustableSplitter) && ((inputPosition == null)||(inputPosition == String.Empty))) ||
                    (connectTo.ComponentType == ComponentType.Splitter) && ((inputPosition == null) || (inputPosition == String.Empty)))
                {
                    ((MiddleComponent)connectTo).ConnectOther(connectFrom);
                }
        }

        /// <summary>
        /// The method that deletes a connection between two components.
        /// Dimitar
        /// </summary>
        /// <param name="first">The first component that is to be disconnected.</param>
        /// <param name="second">The second component that is to be disconnected.</param>
        public bool Disconnect(Component first, Component second)
        {
            var result = this.Connections
                .Where(x => x.InputElement == first)
                .Where(x => x.OutputElement == second)
                .Select(x => x).First();
            for (int i = 0; i < this.Connections.Count; i++)
            {
                if ((this.Connections.ElementAt(i).InputElement == result.InputElement)
                    && (this.Connections.ElementAt(i).OutputElement == result.OutputElement))
                {
                    this.Connections.RemoveAt(i);
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// The method that changes the capacity of a component.
        /// Dimitar
        /// </summary>
        /// <param name="component">The component that is going to have its capacity 
        /// changed.</param>
        public void ChangeCapacity(Component component, double newCapacity)
        {
            var componentFound = this.Components
                .Where(x => x.GetId() == component.GetId())
                .Select(x => x).First();
            if (componentFound != null)
            {
                if (component is Pump)
                {
                    ((Pump)component).SetCapacity(newCapacity);
                }
                else
                {
                    throw new Exception("this type of component could not have its capacity changed,"+
                        " maybe it doesnt even have capacity?");
                }
            }
            else
            {
                throw new Exception("this component was not found in the list of components...");
            }
        }

        /// <summary>
        /// The method that changes the current flow of a component.
        /// Lyubomir
        /// </summary>
        /// <param name="component">The component that is going to have its current
        /// flow changed.</param>
        public void ChangeCurrentFlow(Component component, double newFlow)
        {
            var componentFound = this.Components
            .Where(x => x.GetId() == component.GetId())
            .Select(x => x).First();
            if (componentFound != null)
            {
                if (component is Pump)
                {
                    if (newFlow <= ((Pump)component).Capacity)
                    {
                        ((Pump)component).SetOutput(newFlow);
                    }
                }
                else
                {
                    throw new Exception("this type of component could not have its capacity changed," +
                        " maybe it doesnt even have capacity?");
                }
            }
            else
            {
                throw new Exception("this component was not found in the list of components...");
            }
        }

        /// <summary>
        /// The method that changes the general safety limit.
        /// Lyubomir
        /// </summary>
        /// <param name="newLimit">The new safety limit.</param>
        public void ChangeSafetyLimitGeneral(double newLimit)
        {
            if (newLimit > 0)
            {
                this.generalSafetyLimit = newLimit;
                foreach (Pipeline pipe in this.Connections)
                {
                    pipe.ChangeSafetyLimit(generalSafetyLimit);
                }
            }
            else
            {
                throw new Exception("safety limit should be more than 0");
            }
        }

        /// <summary>
        /// The method that changes the safety limit of a concrete component.
        /// Lyubomir
        /// </summary>
        /// <param name="newLimit">The new safety limit.</param>
        /// <param name="component">The component that is going to have its
        /// safety limit changed.</param>
        public void ChangeSafetyLimit(double newLimit, Pipeline pipe)
        {
            var componentFound = this.Connections
            .Where(x => x.CurrentId == pipe.CurrentId)
            .Select(x => x).First();
            if (componentFound != null)
            {
                componentFound.ChangeSafetyLimit(newLimit);
            }
            else
            {
                throw new Exception("this component was not found in the list of components...");
            }
        }

        /// <summary>
        /// The method that changes the division rate of a splitter.
        /// Lyubomir
        /// </summary>
        /// <param name="rate">The new rate that is going to be set.</param>
        /// <param name="component">The component that is going to have its division 
        /// rate changed.</param>
        public void ChangeSplitterDivisionRate(int rate, Component component)
        {
            var componentFound = this.Components
            .Where(x => x.GetId() == component.GetId())
            .Select(x => x).First();
            if (componentFound != null)
            {
                if (component is AdjustableSplitter)
                {
                    ((AdjustableSplitter)component).SetDivisionRate(rate);
                }
                else
                {
                    throw new Exception("this type of component could not have its capacity changed," +
                        " maybe it doesnt even have capacity?");
                }
            }
            else
            {
                throw new Exception("this component was not found in the list of components...");
            }
            this.CalculateFlow();
        }
    }
}
