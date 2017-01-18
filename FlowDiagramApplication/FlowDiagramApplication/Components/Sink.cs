using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowDiagramApplication.Properties;

namespace FlowDiagramApplication.Components
{
    /// <summary>
    /// The class representing the Sink component.
    /// </summary>
    [Serializable]
    public class Sink : EndpointComponent
    {
        /// <summary>
        /// The input flow of the sink.
        /// </summary>
        private double input;
        public double Input
        {
            get { return this.input; }
        }

        public void SetInput(double flow)
        {
            this.input = flow;
        }

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Sink(Point position, ComponentType type) : base(position, type)
        {
            this.image = Resources.SinkIcon;
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
