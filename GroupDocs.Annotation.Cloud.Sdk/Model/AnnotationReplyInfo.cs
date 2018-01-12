// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotationReplyInfo.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// 
  /// </summary>  
  public class AnnotationReplyInfo 
  {                       
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>  
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the user unique identifier.
        /// </summary>  
        public string UserGuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>  
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>  
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>  
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the replied on.
        /// </summary>  
        public DateTime? RepliedOn { get; set; }

        /// <summary>
        /// Gets or sets the parent reply unique identifier.
        /// </summary>  
        public string ParentReplyGuid { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AnnotationReplyInfo {\n");
          sb.Append("  Guid: ").Append(this.Guid).Append("\n");
          sb.Append("  UserGuid: ").Append(this.UserGuid).Append("\n");
          sb.Append("  UserName: ").Append(this.UserName).Append("\n");
          sb.Append("  UserEmail: ").Append(this.UserEmail).Append("\n");
          sb.Append("  Message: ").Append(this.Message).Append("\n");
          sb.Append("  RepliedOn: ").Append(this.RepliedOn).Append("\n");
          sb.Append("  ParentReplyGuid: ").Append(this.ParentReplyGuid).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
