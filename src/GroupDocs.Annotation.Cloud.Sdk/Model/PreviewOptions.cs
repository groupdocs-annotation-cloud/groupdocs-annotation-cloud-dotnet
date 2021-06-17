// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PreviewOptions.cs">
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
    /// Represents options for GetPages API method
    /// </summary>  
    public class PreviewOptions 
    {                       
        /// <summary>
        /// Preview format. Supported values are: PNG, JPEG or BMP. Default value is PNG.
        /// </summary>
        /// <value>Preview format. Supported values are: PNG, JPEG or BMP. Default value is PNG.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        { 
            /// <summary>
            /// Enum PNG for "PNG"
            /// </summary>            
            PNG,
            
            /// <summary>
            /// Enum JPEG for "JPEG"
            /// </summary>            
            JPEG,
            
            /// <summary>
            /// Enum BMP for "BMP"
            /// </summary>            
            BMP            
        }

        /// <summary>
        /// Preview format. Supported values are: PNG, JPEG or BMP. Default value is PNG.
        /// </summary>
        public FormatEnum? Format { get; set; }

        /// <summary>
        /// Input document description
        /// </summary>  
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Page numbers to preview. All pages proceeded if not specified.
        /// </summary>  
        public List<int?> PageNumbers { get; set; }

        /// <summary>
        /// Preview image width. Not required. Default width used if not specified or 0.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Preview image height. Not required. Default width used if not specified or 0.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the resolution for generated images, in dots per inch. The default value is 96.
        /// </summary>  
        public int? Resolution { get; set; }

        /// <summary>
        /// Render document comments. Default value is 'false'.
        /// </summary>  
        public bool? RenderComments { get; set; }

        /// <summary>
        /// The property that controls whether annotations will be generated on the preview. Default State - true.
        /// </summary>  
        public bool? RenderAnnotations { get; set; }

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
          sb.Append("class PreviewOptions {\n");
          sb.Append("  FileInfo: ").Append(this.FileInfo).Append("\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  PageNumbers: ").Append(this.PageNumbers).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
          sb.Append("  RenderComments: ").Append(this.RenderComments).Append("\n");
          sb.Append("  RenderAnnotations: ").Append(this.RenderAnnotations).Append("\n");
          sb.Append("  FontsPath: ").Append(this.FontsPath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
