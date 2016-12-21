using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// The class representing the pipeline component.
    /// </summary>
    public class Pipeline
    {
        /// <summary>
        /// The safety limit if of the pipeline.
        /// </summary>
        private double safetyLimit;

        /// <summary>
        /// The current flow in the pipeline.
        /// </summary>
        private double currentFlow;

        /// <summary>
        /// The component that provides the input.
        /// </summary>
        private Component inputElement;

        /// <summary>
        /// The component that receives the output.
        /// </summary>
        private Component outputElement;

        /// <summary>
        /// The method that changes the safety limit of the pipeline.
        /// </summary>
        /// <param name="newLimit">The new safety limit of the pipeline.</param>
        public void ChangeSafetyLimit(double newLimit)
        {

        }

        /// <summary>
        /// The constructor of the pipeline.
        /// </summary>
        /// <param name="inputComponent">The component that provides the input.</param>
        /// <param name="outputComponent">The component that receives the output.</param>
        public Pipeline(Component inputComponent, Component outputComponent)
        {

        }
    }
}
