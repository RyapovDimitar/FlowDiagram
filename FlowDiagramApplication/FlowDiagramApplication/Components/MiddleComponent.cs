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
    public abstract class MiddleComponent : Component
    {
        /// <summary>
        /// The constructor of the class
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public MiddleComponent(Point position, ComponentType type) : base(position, type)
        {
            this.upperConnectedComponent = 0;
            this.lowerConnectedComponent = 0;
            this.otherConnected = 0;
        }

        protected int upperConnectedComponent;
        protected int otherConnected;
        protected int lowerConnectedComponent;
        public int OtherConnected
        {
            get { return this.otherConnected; }
        }
        public int UpperConnectedComponent
        {
            get { return this.upperConnectedComponent; }
        }
        public int LowerConnectedComponent
        {
            get { return this.lowerConnectedComponent; }
        }

        public void ConnectUpper(Component c)
        {
            this.upperConnectedComponent = c.GetId();
        }

        public void ConnectLower(Component c)
        {
            this.lowerConnectedComponent = c.GetId();
        }

        public void ConnectOther(Component c)
        {
            this.otherConnected = c.GetId();
        }

    }
}
