// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RowInfo.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  public class RowInfo 
  {                       
        /// <summary>
        /// Gets or sets CharacterCoordinates
        /// </summary>  
        public List<double?> CharacterCoordinates { get; set; }

        /// <summary>
        /// Gets or sets LineHeight
        /// </summary>  
        public double? LineHeight { get; set; }

        /// <summary>
        /// Gets or sets LineLeft
        /// </summary>  
        public double? LineLeft { get; set; }

        /// <summary>
        /// Gets or sets LineTop
        /// </summary>  
        public double? LineTop { get; set; }

        /// <summary>
        /// Gets or sets LineWidth
        /// </summary>  
        public double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets Text
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets TextCoordinates
        /// </summary>  
        public List<double?> TextCoordinates { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RowInfo {\n");
          sb.Append("  CharacterCoordinates: ").Append(this.CharacterCoordinates).Append("\n");
          sb.Append("  LineHeight: ").Append(this.LineHeight).Append("\n");
          sb.Append("  LineLeft: ").Append(this.LineLeft).Append("\n");
          sb.Append("  LineTop: ").Append(this.LineTop).Append("\n");
          sb.Append("  LineWidth: ").Append(this.LineWidth).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  TextCoordinates: ").Append(this.TextCoordinates).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
