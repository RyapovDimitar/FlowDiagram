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
    [Serializable]
    public abstract class EndpointComponent:Component
    {
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
