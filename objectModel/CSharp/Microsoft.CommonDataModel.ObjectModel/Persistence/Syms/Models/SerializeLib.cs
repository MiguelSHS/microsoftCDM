// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{

    /// <summary>
    /// Defines values for SerializeLib.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SerializeLib
    {
        [System.Runtime.Serialization.EnumMember(Value = "org.apache.hadoop.hive.serde2.lazy.LazySimpleSerDe")]
        Orgapachehadoophiveserde2lazyLazySimpleSerDe,
        [System.Runtime.Serialization.EnumMember(Value = "org.apache.hadoop.hive.ql.io.parquet.serde.ParquetHiveSerDe")]
        OrgapachehadoophiveqlioparquetserdeParquetHiveSerDe
    }
}