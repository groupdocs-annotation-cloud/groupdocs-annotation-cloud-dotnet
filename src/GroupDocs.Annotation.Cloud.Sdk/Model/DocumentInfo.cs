// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DocumentInfo.cs">
//  Copyright (c) Aspose Pty Ltd
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
    /// Describes document basic info
    /// </summary>  
    public class DocumentInfo 
    {                       
        /// <summary>
        /// Gets or sets the document name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the document path
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the document extension
        /// </summary>  
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the file format
        /// </summary>  
        public string FileFormat { get; set; }

        /// <summary>
        /// Gets or sets the document size
        /// </summary>  
        public long? Size { get; set; }

        /// <summary>
        /// Gets or sets the document date modified
        /// </summary>  
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Gets or sets the pages
        /// </summary>  
        public List<PageInfo> Pages { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DocumentInfo {\n");
          sb.Append("  Name: ").Append(this.Name).Append("\n");
          sb.Append("  Path: ").Append(this.Path).Append("\n");
          sb.Append("  Extension: ").Append(this.Extension).Append("\n");
          sb.Append("  FileFormat: ").Append(this.FileFormat).Append("\n");
          sb.Append("  Size: ").Append(this.Size).Append("\n");
          sb.Append("  DateModified: ").Append(this.DateModified).Append("\n");
          sb.Append("  Pages: ").Append(this.Pages).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
