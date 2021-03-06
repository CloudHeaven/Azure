// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The list gateway auth keys operation response.
    /// </summary>
    public partial class GatewayListAuthKeysResponse : AzureOperationResponse
    {
        private string _key1;
        
        /// <summary>
        /// Required. Gateway auth key 1.
        /// </summary>
        public string Key1
        {
            get { return this._key1; }
            set { this._key1 = value; }
        }
        
        private string _key2;
        
        /// <summary>
        /// Required. Gateway auth key 2.
        /// </summary>
        public string Key2
        {
            get { return this._key2; }
            set { this._key2 = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayListAuthKeysResponse class.
        /// </summary>
        public GatewayListAuthKeysResponse()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the GatewayListAuthKeysResponse class
        /// with required arguments.
        /// </summary>
        public GatewayListAuthKeysResponse(string key1, string key2)
            : this()
        {
            if (key1 == null)
            {
                throw new ArgumentNullException("key1");
            }
            if (key2 == null)
            {
                throw new ArgumentNullException("key2");
            }
            this.Key1 = key1;
            this.Key2 = key2;
        }
    }
}
