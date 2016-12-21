﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// This is the main class that executes the logic of the flow diagram application.
    /// </summary>
    class FlowDiagram
    {
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

        /// <summary>
        /// The method that calculates the current flow in the flow diagram.
        /// </summary>
        /// <returns>The current flow in the flow diagram as a double</returns>
        public double CalculateFlow()
        {
            return -1;
        }

        /// <summary>
        /// The method that draws a flow diagram in the drawing space.
        /// </summary>
        /// <param name="fd">The flow diagram that is to be drawn.</param>
        public void DrawFlowDiagram(FlowDiagram fd)
        {

        }

        /// <summary>
        /// The method that clears the flow diagram from the drawing space.
        /// </summary>
        public void ClearFlowDiagram()
        {

        }

        /// <summary>
        /// The method that serializes the flow diagram and saves it to a file.
        /// </summary>
        /// <param name="filename">The name of the file that is to be saved.</param>
        public void SaveToFile(string filename)
        {

        }

        /// <summary>
        /// The method that loads a file and deserializes a flow diagram from it. 
        /// </summary>
        /// <param name="filename">The file that is to be loaded.</param>
        public void LoadFromFile(string filename)
        {
            
        }

        /// <summary>
        /// The method that adds a component to the list with components.
        /// </summary>
        /// <param name="position">The position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public void AddComponent(Point position, ComponentType type)
        {

        }

        /// <summary>
        /// The method that is deleting a component from the list of components.
        /// </summary>
        /// <param name="component">The component that is to be deleted.</param>
        public void DeleteComponent(Component component)
        {

        }

        /// <summary>
        /// The method that changes the position of a component.
        /// </summary>
        /// <param name="position">The new position for the component</param>
        /// <param name="component">The component that is going to have its 
        /// position changed.</param>
        public void ChangeComponentPosition(Point position, Component component)
        {

        }

        /// <summary>
        /// The method that makes a connection between two components.
        /// </summary>
        /// <param name="connectTo">The second component that is to be connected.</param>
        /// <param name="connectFrom">The first component that is to be connected.</param>
        public void Connect(Component connectTo, Component connectFrom)
        {

        }

        /// <summary>
        /// The method that deletes a connection between two components.
        /// </summary>
        /// <param name="first">The first component that is to be disconnected.</param>
        /// <param name="second">The second component that is to be disconnected.</param>
        public void Disconnect(Component first, Component second)
        {

        }

        /// <summary>
        /// The method that changes the capacity of a component.
        /// </summary>
        /// <param name="component">The component that is going to have its capacity 
        /// changed.</param>
        public void ChangeCapacity(Component component)
        {

        }

        /// <summary>
        /// The method that changes the current flow of a component.
        /// </summary>
        /// <param name="component">The component that is going to have its current
        /// flow changed.</param>
        public void ChangeCurrentFlow(Component component)
        {

        }

        /// <summary>
        /// The method that changes the general safety limit.
        /// </summary>
        /// <param name="newLimit">The new safety limit.</param>
        public void ChangeSafetyLimitGeneral(double newLimit)
        {

        }

        /// <summary>
        /// The method that changes the safety limit of a concrete component.
        /// </summary>
        /// <param name="newLimit">The new safety limit.</param>
        /// <param name="component">The component that is going to have its
        /// safety limit changed.</param>
        public void ChangeSafetyLimit(double newLimit, Component component)
        {

        }

        /// <summary>
        /// The method that changes the division rate of a splitter.
        /// </summary>
        /// <param name="rate">The new rate that is going to be set.</param>
        /// <param name="component">The component that is going to have its division 
        /// rate changed.</param>
        public void ChangeSplitterDivisionRate(double rate, Component component)
        {

        }
    }
}
