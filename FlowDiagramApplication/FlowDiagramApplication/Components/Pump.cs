using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// The class representing the pump component.
    /// </summary>
    public class Pump : EndpointComponent
    {
        /// <summary>
        /// The current output of the pump.
        /// </summary>
        private double output;

        /// <summary>
        /// The capacity of the pump.
        /// </summary>
        private double capacity;

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Pump(Point position, ComponentType type) : base(position, type)
        {
            image = Image.FromFile("D:/Fontys/OOD2/Project/Pipeline app design/PumpIcon.PNG");
        }

        /// <summary>
        /// The method that connects the next component to the pump.
        /// </summary>
        /// <param name="component"></param>
        public override void Connect(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the next component to the pump.
        /// </summary>
        public override void Disconnect()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that sets the output of the pump.
        /// </summary>
        /// <param name="output">The output that is to be set.</param>
        public void SetOutput(double output)
        {
            
        }

        /// <summary>
        /// The method that sets the capacity of the pump.
        /// </summary>
        /// <param name="capacity">The capacity that is to be set.</param>
        public void SetCapacity(double capacity)
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
