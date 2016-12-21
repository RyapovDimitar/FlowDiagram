using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication.Components
{
    /// <summary>
    /// The class representing the Merger component.
    /// </summary>
    public class Merger : MiddleComponent
    {
        /// <summary>
        /// The component connected to the up input of the merger.
        /// </summary>
        private int inputUp;

        /// <summary>
        /// The component connected to the down input of the merger.
        /// </summary>
        private int inputDown;

        /// <summary>
        /// The method that connects first(up) input component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public override void ConnectInput(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that connects second(down) input component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public void ConnectSecondInput(Component component)
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
        /// The method that disconnects the up input component.
        /// </summary>
        public override void DisconnectInput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the second input component.
        /// </summary>
        public void DisconnectSecondInput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the output component.
        /// </summary>
        public override void DisconnectOutput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Merger(Point position, ComponentType type) : base(position, type)
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
