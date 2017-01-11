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
    public abstract class MiddleComponent:Component
    {
        /// <summary>
        /// The method that connects input component.
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public abstract void ConnectInput(Component component);

        /// <summary>
        /// The method that connects output component.
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public abstract void ConnectOutput(Component component);

        /// <summary>
        /// The method that disconnects input component.
        /// </summary>
        public abstract void DisconnectInput();

        /// <summary>
        /// The method that disconnects output component.
        /// </summary>
        public abstract void DisconnectOutput();

        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public MiddleComponent(Point position, ComponentType type) : base(position, type)
        {
        }

    }
}
