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
    [Serializable]
    public class Pipeline
    {
        /// <summary>
        /// Static id counter that is going to be incremented for each new component instance.
        /// </summary>
        protected static int id = 0;

        /// <summary>
        /// The current component instance id.
        /// </summary>
        private int currentId;
        public int CurrentId
        {
            get { return this.currentId; }
        }

        /// <summary>
        /// The safety limit if of the pipeline.
        /// </summary>
        private double safetyLimit;
        public double SafetyLimit
        {
        get {return this.safetyLimit; } }

        /// <summary>
        /// The current flow in the pipeline.
        /// </summary>
        private double currentFlow = 0;
        public double CurrentFlow
        {
            get { return this.currentFlow; }
        }
        public int CheckColor()
        {
            if (currentFlow < (0.9 * safetyLimit))
            {
                return 1;
            }
            else if (currentFlow < safetyLimit)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        /// <summary>
        /// The component that provides the input.
        /// </summary>
        private Component inputElement;

        /// <summary>
        /// The public getter of the input element.
        /// TODO: To be added in the class description.
        /// </summary>
        public Component InputElement
        {
            get
            {
                return this.inputElement;
            }
        }

        /// <summary>
        /// The component that receives the output.
        /// </summary>
        private Component outputElement;

        /// <summary>
        /// The public getter of the output element.
        /// TODO: To be added in the class description.
        /// </summary>
        public Component OutputElement
        {
            get
            {
                return this.outputElement;
            }
        }

        public void SetFlow(double flow)
        {
            if (flow >= 0)
            {
                this.currentFlow = flow;
            }
            else
            {
                throw new Exception("the flow should be more than 0");
            }
        }

        /// <summary>
        /// The method that changes the safety limit of the pipeline.
        /// </summary>
        /// <param name="newLimit">The new safety limit of the pipeline.</param>
        public void ChangeSafetyLimit(double newLimit)
        {
            if (newLimit > 0)
            {
                this.safetyLimit = newLimit;
            }
            else
            {
                throw new Exception("the safety limit of a pipe should be more than 0");
            }
        }

        /// <summary>
        /// The constructor of the pipeline.
        /// </summary>
        /// <param name="inputComponent">The component that provides the input.</param>
        /// <param name="outputComponent">The component that receives the output.</param>
        public Pipeline(Component inputComponent, Component outputComponent)
        {
            this.inputElement = inputComponent;
            this.outputElement = outputComponent;
            this.currentFlow = 0;
            id++;
            currentId = id;
            //TODO = remove 
            this.safetyLimit = 100;
        }
    }
}
