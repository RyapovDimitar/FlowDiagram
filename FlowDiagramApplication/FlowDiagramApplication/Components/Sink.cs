using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication.Components
{
    /// <summary>
    /// The class representing the Sink component.
    /// </summary>
    public class Sink : EndpointComponent
    {
        /// <summary>
        /// The input flow of the sink.
        /// </summary>
        private double input;

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Sink(Point position, ComponentType type) : base(position, type)
        {
        }

        /// <summary>
        /// The method that connects the previous component to the sink.
        /// </summary>
        /// <param name="component"></param>
        public override void Connect(Component component)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The method that disconnects the previous component to the sink. 
        /// </summary>
        public override void Disconnect()
        {
            throw new NotImplementedException();
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
