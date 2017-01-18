using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// The main class that represents the Component object - this is the main class, 
    /// which is inherited by the endpoint and middle components.
    /// </summary>
    [Serializable]
    public abstract class Component
    {
        /// <summary>
        /// Static id counter that is going to be incremented for each new component instance.
        /// </summary>
        protected static int id = 0;

        /// <summary>
        /// The current component instance id.
        /// </summary>
        protected int currentId;

        /// <summary>
        /// The size of the componenet picture.
        /// </summary>
        protected static Size size = new Size(20, 20);

        /// <summary>
        /// The string for the imagepath of the component.
        /// </summary>
        protected string imagepath;

        /// <summary>
        /// The image of the component.
        /// </summary>
        protected Image image;
        /// <summary>
        /// The image of the component.
        /// </summary>
        public Image Image
        {
            get { return image; }
        }
        /// <summary>
        /// The type of the component.
        /// </summary>
        protected ComponentType componentType;

        /// <summary>
        /// The type of the component.
        /// </summary>
        // EXTRA I added the get for componentType
        public ComponentType ComponentType
        {
            get { return componentType; }
        }

        /// <summary>
        /// The position of the top left corner of the component.
        /// </summary>
        private System.Drawing.Point position;
        public System.Drawing.Point Position
        {
            get
            {
                return this.position;
            }
        }

        /// <summary>
        /// The constructor of the component.
        /// </summary>
        /// <param name="position">The initial position of the component.</param>
        /// <param name="type">The type of the component.</param>
        public Component(Point position, ComponentType type)
        {
            this.position = position;
            this.componentType = type;
            id++;
            currentId = id;
        }

        /// <summary>
        /// The method that is going to return the information for the component as a string.
        /// </summary>
        /// <returns>The info string of the component.</returns>
        public override string ToString()
        {
            return "The component is " + this.componentType.ToString() + " " + Convert.ToString(position);
        }

        /// <summary>
        /// The method that saves a new position of the component.
        /// </summary>
        /// <param name="newposition">The coordinates of the new position.</param>
        public void ChangePosition(Point newposition)
        {
            this.position = newposition;
        }

        public int GetId()
        {
            return currentId;
        }
    }
}
