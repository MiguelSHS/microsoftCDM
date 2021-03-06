// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Data column.
    /// </summary>
    public partial class DataColumn
    {
        /// <summary>
        /// Initializes a new instance of the DataColumn class.
        /// </summary>
        public DataColumn() { }

        /// <summary>
        /// Initializes a new instance of the DataColumn class.
        /// </summary>
        /// <param name="name">Column name.</param>
        public DataColumn(string name, TypeInfo originDataTypeName)
        {
            Name = name;
            OriginDataTypeName = originDataTypeName;
        }

        /// <summary>
        /// Gets or sets column name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "OriginDataTypeName")]
        public TypeInfo OriginDataTypeName { get; set; }

    }
}
