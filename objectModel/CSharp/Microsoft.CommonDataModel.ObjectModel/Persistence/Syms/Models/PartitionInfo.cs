// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Partition information.
    /// </summary>
    public partial class PartitionInfo : MDEntity
    {
        /// <summary>
        /// Initializes a new instance of the PartitionInfo class.
        /// </summary>
        public PartitionInfo() { }

        /// <summary>
        /// Initializes a new instance of the PartitionInfo class.
        /// </summary>
        /// <param name="name">Entity Name.</param>
        /// <param name="type">Possible values include: 'DATABASE', 'TABLE',
        /// 'SCHEMA', 'VIEW', 'FUNCTION', 'PARTITIONINFO',
        /// 'RELATIONSHIP'</param>
        /// <param name="id">Entity Resource Id.</param>
        public PartitionInfo(string name, SASEntityType type, string id = default(string), object properties = default(object))
            : base(name, type, id, properties)
        {
        }
    }
}
