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
    /// The class representing the adjustable splitter component.
    /// </summary>
    [Serializable]
    public class AdjustableSplitter:MiddleComponent
    {
        /// <summary>
        /// The division rate of the adjustable splitter. 
        /// </summary>
        // EXTRA I added the get property and set the default divisionRate at 70 for testing purposes
        private int divisionRate = 70;

        public int DivisionRate
        {
            get { return this.divisionRate; }
        }

        /// <summary>
        /// The method that sets the division rate.
        /// </summary>
        /// <param name="rate">The rate that is going to be set.</param>
        public void SetDivisionRate(int rate)
        {
            divisionRate = rate;
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
            this.image = Resources.Adj__SplitterIcon;
        }
    }
}
