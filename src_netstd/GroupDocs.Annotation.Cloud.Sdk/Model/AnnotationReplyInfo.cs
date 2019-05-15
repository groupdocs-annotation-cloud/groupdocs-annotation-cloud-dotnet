// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotationReplyInfo.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Annotation.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Annotation.Cloud.Sdk.Model
{
    /// <summary>
    /// Describes annotation reply properties
    /// </summary>
    [DataContract]
    public partial class AnnotationReplyInfo
    {
        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        /// <value>Gets or sets the unique identifier</value>
        [DataMember(Name="Guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the user&#39;s unique identifier
        /// </summary>
        /// <value>Gets or sets the user&#39;s unique identifier</value>
        [DataMember(Name="UserGuid", EmitDefaultValue=false)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Gets or sets the user&#39;s name
        /// </summary>
        /// <value>Gets or sets the user&#39;s name</value>
        [DataMember(Name="UserName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user email
        /// </summary>
        /// <value>Gets or sets the user email</value>
        [DataMember(Name="UserEmail", EmitDefaultValue=false)]
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the message
        /// </summary>
        /// <value>Gets or sets the message</value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the reply time
        /// </summary>
        /// <value>Gets or sets the reply time</value>
        [DataMember(Name="RepliedOn", EmitDefaultValue=false)]
        public DateTime? RepliedOn { get; set; }

        /// <summary>
        /// Gets or sets the parent reply unique identifier
        /// </summary>
        /// <value>Gets or sets the parent reply unique identifier</value>
        [DataMember(Name="ParentReplyGuid", EmitDefaultValue=false)]
        public string ParentReplyGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnotationReplyInfo {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RepliedOn: ").Append(RepliedOn).Append("\n");
            sb.Append("  ParentReplyGuid: ").Append(ParentReplyGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
