using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowDiagramApplication.Properties;

namespace FlowDiagramApplication
{
    /// <summary>
    /// The class representing the pump component.
    /// </summary>
    [Serializable]
    public class Pump : EndpointComponent
    {
        /// <summary>
        /// The current output of the pump.
        /// </summary>
        private double output;
        //EXTRA I added get for output and capacity
        public double Output
        {
            get { return this.output; }
        }

        /// <summary>
        /// The capacity of the pump.
        /// </summary>
        private double capacity;
        public double Capacity
        {
            get { return this.capacity; }
        }
        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Pump(Point position, ComponentType type) : base(position, type)
        {
            this.image = Resources.PumpIcon;
            this.capacity = 0;
            this.output = 0;
        }

        /// <summary>
        /// The method that sets the output of the pump.
        /// </summary>
        /// <param name="output">The output that is to be set.</param>
        public void SetOutput(double output)
        {
            this.output = output;
        }

        /// <summary>
        /// The method that sets the capacity of the pump.
        /// </summary>
        /// <param name="capacity">The capacity that is to be set.</param>
        public void SetCapacity(double capacity)
        {
            this.capacity = capacity;
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
