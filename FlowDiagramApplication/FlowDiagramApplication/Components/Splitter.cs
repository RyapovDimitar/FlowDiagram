using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication.Components
{
    /// <summary>
    /// The class representing the Splitter component.
    /// </summary>
    public class Splitter : MiddleComponent
    {
        /// <summary>
        /// The method that connects the input component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public override void ConnectInput(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that connects the first(up) output component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public override void ConnectOutput(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that connects the second(down) output component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public void ConnectSecondOutput(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the input component.
        /// </summary>
        public override void DisconnectInput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the first output component.
        /// </summary>
        public override void DisconnectOutput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the second output component.
        /// </summary>
        public void DisconnectSecondOutput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Splitter(Point position, ComponentType type) : base(position, type)
        {

        }

        /// <summary>
        /// The method that returns the info string of the component.
        /// </summary>
        /// <returns>Info string with the information about the component.</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
