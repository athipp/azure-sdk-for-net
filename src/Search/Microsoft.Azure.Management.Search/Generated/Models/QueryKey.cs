// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes an API key for a given Azure Search service that has
    /// permissions for query operations only.
    /// </summary>
    public partial class QueryKey
    {
        /// <summary>
        /// Initializes a new instance of the QueryKey class.
        /// </summary>
        public QueryKey() { }

        /// <summary>
        /// Initializes a new instance of the QueryKey class.
        /// </summary>
        public QueryKey(string name = default(string), string key = default(string))
        {
            Name = name;
            Key = key;
        }

        /// <summary>
        /// Gets the name of the query API key; may be empty.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the value of the query API key.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; private set; }

    }
}
