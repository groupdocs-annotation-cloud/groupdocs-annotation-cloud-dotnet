// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RowInfo.cs">
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
    /// Describes text row information
    /// </summary>
    [DataContract]
    public partial class RowInfo
    {
        /// <summary>
        /// Gets or sets the list of character coordinates
        /// </summary>
        /// <value>Gets or sets the list of character coordinates</value>
        [DataMember(Name="CharacterCoordinates", EmitDefaultValue=false)]
        public List<double?> CharacterCoordinates { get; set; }

        /// <summary>
        /// Gets or sets the text line height
        /// </summary>
        /// <value>Gets or sets the text line height</value>
        [DataMember(Name="LineHeight", EmitDefaultValue=false)]
        public double? LineHeight { get; set; }

        /// <summary>
        /// Gets or sets the x coordinate of the text line upper left corner
        /// </summary>
        /// <value>Gets or sets the x coordinate of the text line upper left corner</value>
        [DataMember(Name="LineLeft", EmitDefaultValue=false)]
        public double? LineLeft { get; set; }

        /// <summary>
        /// Gets or sets the y coordinate of the text line upper left corner
        /// </summary>
        /// <value>Gets or sets the y coordinate of the text line upper left corner</value>
        [DataMember(Name="LineTop", EmitDefaultValue=false)]
        public double? LineTop { get; set; }

        /// <summary>
        /// Gets or sets the text line width
        /// </summary>
        /// <value>Gets or sets the text line width</value>
        [DataMember(Name="LineWidth", EmitDefaultValue=false)]
        public double? LineWidth { get; set; }

        /// <summary>
        /// Gets or sets the text
        /// </summary>
        /// <value>Gets or sets the text</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the list of text coordinates
        /// </summary>
        /// <value>Gets or sets the list of text coordinates</value>
        [DataMember(Name="TextCoordinates", EmitDefaultValue=false)]
        public List<double?> TextCoordinates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RowInfo {\n");
            sb.Append("  CharacterCoordinates: ").Append(CharacterCoordinates).Append("\n");
            sb.Append("  LineHeight: ").Append(LineHeight).Append("\n");
            sb.Append("  LineLeft: ").Append(LineLeft).Append("\n");
            sb.Append("  LineTop: ").Append(LineTop).Append("\n");
            sb.Append("  LineWidth: ").Append(LineWidth).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  TextCoordinates: ").Append(TextCoordinates).Append("\n");
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
