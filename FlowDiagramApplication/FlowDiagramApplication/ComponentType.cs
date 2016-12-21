using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDiagramApplication
{
    /// <summary>
    /// Enumeration representing the different types of components in the flow diagram.
    /// </summary>
    public enum ComponentType
    {
        /// <summary>
        /// The type of the component is merger.
        /// </summary>
        Merger,
        /// <summary>
        /// The type of the component is splitter.
        /// </summary>
        Splitter,
        /// <summary>
        /// The type of the component is adjustable splitter.
        /// </summary>
        AdjustableSplitter,
        /// <summary>
        /// The type of the component is pump.
        /// </summary>
        Pump,
        /// <summary>
        /// The type of the component is sink.
        /// </summary>
        Sink
    }
}
