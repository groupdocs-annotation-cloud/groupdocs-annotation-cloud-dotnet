// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotationInfo.cs">
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
  public class AnnotationInfo 
  {                       
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>            
            Text,
            
            /// <summary>
            /// Enum Area for "Area"
            /// </summary>            
            Area,
            
            /// <summary>
            /// Enum Point for "Point"
            /// </summary>            
            Point,
            
            /// <summary>
            /// Enum TextStrikeout for "TextStrikeout"
            /// </summary>            
            TextStrikeout,
            
            /// <summary>
            /// Enum Polyline for "Polyline"
            /// </summary>            
            Polyline,
            
            /// <summary>
            /// Enum TextField for "TextField"
            /// </summary>            
            TextField,
            
            /// <summary>
            /// Enum Watermark for "Watermark"
            /// </summary>            
            Watermark,
            
            /// <summary>
            /// Enum TextReplacement for "TextReplacement"
            /// </summary>            
            TextReplacement,
            
            /// <summary>
            /// Enum Arrow for "Arrow"
            /// </summary>            
            Arrow,
            
            /// <summary>
            /// Enum TextRedaction for "TextRedaction"
            /// </summary>            
            TextRedaction,
            
            /// <summary>
            /// Enum ResourcesRedaction for "ResourcesRedaction"
            /// </summary>            
            ResourcesRedaction,
            
            /// <summary>
            /// Enum TextUnderline for "TextUnderline"
            /// </summary>            
            TextUnderline,
            
            /// <summary>
            /// Enum Distance for "Distance"
            /// </summary>            
            Distance            
        }

        /// <summary>
        /// Gets or sets the access.
        /// </summary>
        /// <value>Gets or sets the access.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        { 
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>            
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>            
            Private            
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public AnnotationType Type { get; set; }

        /// <summary>
        /// Gets or sets the access.
        /// </summary>
        public AccessEnum? Access { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>  
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the document unique identifier.
        /// </summary>  
        public long? DocumentGuid { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the creator unique identifier.
        /// </summary>  
        public string CreatorGuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the creator.
        /// </summary>  
        public string CreatorName { get; set; }

        /// <summary>
        /// Gets or sets the creator email.
        /// </summary>  
        public string CreatorEmail { get; set; }

        /// <summary>
        /// Gets or sets the box.
        /// </summary>  
        public Rectangle Box { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the annotation position.
        /// </summary>  
        public Point AnnotationPosition { get; set; }

        /// <summary>
        /// Gets or sets the SVG path.
        /// </summary>  
        public string SvgPath { get; set; }

        /// <summary>
        /// Gets or sets the replies.
        /// </summary>  
        public AnnotationReplyInfo[] Replies { get; set; }

        /// <summary>
        /// Gets or sets the created on.
        /// </summary>  
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the color of the font.
        /// </summary>  
        public int? FontColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the pen.
        /// </summary>  
        public int? PenColor { get; set; }

        /// <summary>
        /// Gets or sets the width of the pen.
        /// </summary>  
        public int? PenWidth { get; set; }

        /// <summary>
        /// Gets or sets the pen style.
        /// </summary>  
        public int? PenStyle { get; set; }

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>  
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the field text.
        /// </summary>  
        public string FieldText { get; set; }

        /// <summary>
        /// Gets or sets the font family.
        /// </summary>  
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the size of the font.
        /// </summary>  
        public double? FontSize { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AnnotationInfo {\n");
          sb.Append("  Guid: ").Append(this.Guid).Append("\n");
          sb.Append("  DocumentGuid: ").Append(this.DocumentGuid).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  CreatorGuid: ").Append(this.CreatorGuid).Append("\n");
          sb.Append("  CreatorName: ").Append(this.CreatorName).Append("\n");
          sb.Append("  CreatorEmail: ").Append(this.CreatorEmail).Append("\n");
          sb.Append("  Box: ").Append(this.Box).Append("\n");
          sb.Append("  PageNumber: ").Append(this.PageNumber).Append("\n");
          sb.Append("  AnnotationPosition: ").Append(this.AnnotationPosition).Append("\n");
          sb.Append("  SvgPath: ").Append(this.SvgPath).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Access: ").Append(this.Access).Append("\n");
          sb.Append("  Replies: ").Append(this.Replies).Append("\n");
          sb.Append("  CreatedOn: ").Append(this.CreatedOn).Append("\n");
          sb.Append("  FontColor: ").Append(this.FontColor).Append("\n");
          sb.Append("  PenColor: ").Append(this.PenColor).Append("\n");
          sb.Append("  PenWidth: ").Append(this.PenWidth).Append("\n");
          sb.Append("  PenStyle: ").Append(this.PenStyle).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  FieldText: ").Append(this.FieldText).Append("\n");
          sb.Append("  FontFamily: ").Append(this.FontFamily).Append("\n");
          sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
