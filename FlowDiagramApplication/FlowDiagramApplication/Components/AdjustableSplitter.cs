using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication.Components
{
    /// <summary>
    /// The class representing the adjustable splitter component.
    /// </summary>
    class AdjustableSplitter:MiddleComponent
    {
        /// <summary>
        /// The division rate of the adjustable splitter. 
        /// </summary>
        private double divisionRate;

        /// <summary>
        /// The component connected to the up output of the splitter.
        /// </summary>
        private int outputUp;

        /// <summary>
        /// The component connected to the down output of the splitter.
        /// </summary>
        private int outputDown;

        /// <summary>
        /// The method that connects second(down) output component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public void ConnectSecondOutput(Component component)
        {

        }

        /// <summary>
        /// The method that makes the connection with the the input component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public override void ConnectInput(Component component)
        {

        }

        /// <summary>
        /// The method that makes the connection with the output component
        /// </summary>
        /// <param name="component">The component that is going to be connected.</param>
        public override void ConnectOutput(Component component)
        {

        }

        /// <summary>
        /// The method that disconnects the input component.
        /// </summary>
        public override void DisconnectInput()
        {

        }

        /// <summary>
        /// The method that disconnects the output component.
        /// </summary>
        public override void DisconnectOutput()
        {

        }

        /// <summary>
        /// The method that disconnects the second output component.
        /// </summary>
        public void DisconnectSecondOutput()
        {

        }

        /// <summary>
        /// The method that sets the division rate.
        /// </summary>
        /// <param name="rate">The rate that is going to be set.</param>
        public void SetDivisionRate(double rate)
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

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public AdjustableSplitter(Point position, ComponentType type) : base(position, type)
        {

        }
    }
}
