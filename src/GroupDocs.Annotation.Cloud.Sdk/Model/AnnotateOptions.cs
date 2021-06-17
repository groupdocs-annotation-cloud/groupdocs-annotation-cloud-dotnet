// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotateOptions.cs">
//  Copyright (c) 2003-2021 Aspose Pty Ltd
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
    /// Defines options for annotating documents
    /// </summary>  
    public class AnnotateOptions 
    {                       
        /// <summary>
        /// Input document description
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// List of annotations to add to the document
        /// </summary>  
        public List<AnnotationInfo> Annotations { get; set; }

        /// <summary>
        /// First page number when saving page range
        /// </summary>  
        public int? FirstPage { get; set; }

        /// <summary>
        /// Last page number when saving page range
        /// </summary>  
        public int? LastPage { get; set; }

        /// <summary>
        /// Indicates whether to save only annotated pages
        /// </summary>  
        public bool? OnlyAnnotatedPages { get; set; }

        /// <summary>
        /// Path to output document in the cloud storage. Required for Add method. Not required if Annotate (with file result) method used.
        /// </summary>  
        public string OutputPath { get; set; }

        /// <summary>
        /// The path to directory containing custom fonts in storage
        /// </summary>  
        public string FontsPath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AnnotateOptions {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  Annotations: ").Append(this.Annotations).Append("\n");
          sb.Append("  FirstPage: ").Append(this.FirstPage).Append("\n");
          sb.Append("  LastPage: ").Append(this.LastPage).Append("\n");
          sb.Append("  OnlyAnnotatedPages: ").Append(this.OnlyAnnotatedPages).Append("\n");
          sb.Append("  OutputPath: ").Append(this.OutputPath).Append("\n");
          sb.Append("  FontsPath: ").Append(this.FontsPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
