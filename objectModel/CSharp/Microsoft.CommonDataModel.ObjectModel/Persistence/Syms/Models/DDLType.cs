// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Models
{

    /// <summary>
    /// Defines values for DDLType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DDLType
    {
        [System.Runtime.Serialization.EnumMember(Value = "CREATE")]
        CREATE,
        [System.Runtime.Serialization.EnumMember(Value = "ALTER")]
        ALTER,
        [System.Runtime.Serialization.EnumMember(Value = "DROP")]
        DROP
    }
}
