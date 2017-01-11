using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// The class representing the group of components that are endpoint components.
    /// </summary>
    public abstract class EndpointComponent:Component
    {
        /// <summary>
        /// The method that connects a component to the endpoint component.
        /// </summary>
        /// <param name="component">The component that is conencted.</param>
        public abstract void Connect(Component component);

        /// <summary>
        /// The method that disconnects a component from the endpoint component.
        /// </summary>
        public abstract void Disconnect();

        /// <summary>
        /// The constructor of the class.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public EndpointComponent(Point position, ComponentType type) : base(position, type)
        {

        }
    }
}
