// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.CommonDataModel.ObjectModel.Persistence.Syms.Types
{
    using Newtonsoft.Json.Linq;
    public class AttributeGroupReferenceDefinition
    {
        public JToken AttributeGroupReference;
        public bool? Optional { get; set; }
    }
}
