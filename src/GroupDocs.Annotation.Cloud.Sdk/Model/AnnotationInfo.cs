// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotationInfo.cs">
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
    /// Describes annotation properties
    /// </summary>  
    public class AnnotationInfo 
    {                       
        /// <summary>
        /// Gets or sets text horizontal alignment
        /// </summary>
        /// <value>Gets or sets text horizontal alignment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HorizontalAlignmentEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right            
        }

        /// <summary>
        /// Gets or sets text vertical alignment
        /// </summary>
        /// <value>Gets or sets text vertical alignment</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VerticalAlignmentEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>            
            Top,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>            
            Bottom            
        }

        /// <summary>
        /// Gets or sets the annotation type
        /// </summary>
        /// <value>Gets or sets the annotation type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Area for "Area"
            /// </summary>            
            Area,
            
            /// <summary>
            /// Enum Arrow for "Arrow"
            /// </summary>            
            Arrow,
            
            /// <summary>
            /// Enum Distance for "Distance"
            /// </summary>            
            Distance,
            
            /// <summary>
            /// Enum Ellipse for "Ellipse"
            /// </summary>            
            Ellipse,
            
            /// <summary>
            /// Enum Link for "Link"
            /// </summary>            
            Link,
            
            /// <summary>
            /// Enum Point for "Point"
            /// </summary>            
            Point,
            
            /// <summary>
            /// Enum Polyline for "Polyline"
            /// </summary>            
            Polyline,
            
            /// <summary>
            /// Enum ResourcesRedaction for "ResourcesRedaction"
            /// </summary>            
            ResourcesRedaction,
            
            /// <summary>
            /// Enum TextField for "TextField"
            /// </summary>            
            TextField,
            
            /// <summary>
            /// Enum TextHighlight for "TextHighlight"
            /// </summary>            
            TextHighlight,
            
            /// <summary>
            /// Enum TextRedaction for "TextRedaction"
            /// </summary>            
            TextRedaction,
            
            /// <summary>
            /// Enum TextReplacement for "TextReplacement"
            /// </summary>            
            TextReplacement,
            
            /// <summary>
            /// Enum TextStrikeout for "TextStrikeout"
            /// </summary>            
            TextStrikeout,
            
            /// <summary>
            /// Enum TextUnderline for "TextUnderline"
            /// </summary>            
            TextUnderline,
            
            /// <summary>
            /// Enum Watermark for "Watermark"
            /// </summary>            
            Watermark,
            
            /// <summary>
            /// Enum Image for "Image"
            /// </summary>            
            Image            
        }

        /// <summary>
        /// Gets or sets the annotation&#39;s pen style
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s pen style</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PenStyleEnum
        { 
            /// <summary>
            /// Enum Solid for "Solid"
            /// </summary>            
            Solid,
            
            /// <summary>
            /// Enum Dash for "Dash"
            /// </summary>            
            Dash,
            
            /// <summary>
            /// Enum DashDot for "DashDot"
            /// </summary>            
            DashDot,
            
            /// <summary>
            /// Enum Dot for "Dot"
            /// </summary>            
            Dot,
            
            /// <summary>
            /// Enum LongDash for "LongDash"
            /// </summary>            
            LongDash,
            
            /// <summary>
            /// Enum DashDotDot for "DashDotDot"
            /// </summary>            
            DashDotDot            
        }

        /// <summary>
        /// Gets or sets text horizontal alignment
        /// </summary>
        public HorizontalAlignmentEnum? HorizontalAlignment { get; set; }

        /// <summary>
        /// Gets or sets text vertical alignment
        /// </summary>
        public VerticalAlignmentEnum? VerticalAlignment { get; set; }

        /// <summary>
        /// Gets or sets the annotation type
        /// </summary>
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s pen style
        /// </summary>
        public PenStyleEnum? PenStyle { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the annotation text
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// GGets or sets text to be replaced
        /// </summary>  
        public string TextToReplace { get; set; }

        /// <summary>
        /// Gets or sets the creator unique identifier
        /// </summary>  
        public int? CreatorId { get; set; }

        /// <summary>
        /// Gets or sets the name of the creator
        /// </summary>  
        public string CreatorName { get; set; }

        /// <summary>
        /// Gets or sets the creator's email
        /// </summary>  
        public string CreatorEmail { get; set; }

        /// <summary>
        /// Gets or sets the box where annotation will be placed
        /// </summary>  
        public Rectangle Box { get; set; }

        /// <summary>
        /// Gets or sets collection of points that describe rectangles with text
        /// </summary>  
        public List<Point> Points { get; set; }

        /// <summary>
        /// Gets or sets the number of page where annotation will be placed
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the annotation position
        /// </summary>  
        public Point AnnotationPosition { get; set; }

        /// <summary>
        /// Gets or sets the annotation SVG path
        /// </summary>  
        public string SvgPath { get; set; }

        /// <summary>
        /// Gets or sets the array of annotation replies
        /// </summary>  
        public List<AnnotationReplyInfo> Replies { get; set; }

        /// <summary>
        /// Gets or sets the annotation created on date
        /// </summary>  
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the annotation's font color
        /// </summary>  
        public int? FontColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation's pen color
        /// </summary>  
        public int? PenColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation's pen width
        /// </summary>  
        public int? PenWidth { get; set; }

        /// <summary>
        /// Gets or sets the annotation's background color 
        /// </summary>  
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation's font family
        /// </summary>  
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the annotation's font size 
        /// </summary>  
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the annotation's opacity
        /// </summary>  
        public double? Opacity { get; set; }

        /// <summary>
        /// Gets or sets the watermark annotation's rotation angle
        /// </summary>  
        public double? Angle { get; set; }

        /// <summary>
        /// Gets or sets z-index. Default value is 0 The z-index property specifies the stack order of an element.
        /// </summary>  
        public int? ZIndex { get; set; }

        /// <summary>
        /// Gets or sets annotation link url
        /// </summary>  
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets image file path in cloud storage, for Image annotations
        /// </summary>  
        public string ImagePath { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class AnnotationInfo {\n");
          sb.Append("  Id: ").Append(this.Id).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  TextToReplace: ").Append(this.TextToReplace).Append("\n");
          sb.Append("  HorizontalAlignment: ").Append(this.HorizontalAlignment).Append("\n");
          sb.Append("  VerticalAlignment: ").Append(this.VerticalAlignment).Append("\n");
          sb.Append("  CreatorId: ").Append(this.CreatorId).Append("\n");
          sb.Append("  CreatorName: ").Append(this.CreatorName).Append("\n");
          sb.Append("  CreatorEmail: ").Append(this.CreatorEmail).Append("\n");
          sb.Append("  Box: ").Append(this.Box).Append("\n");
          sb.Append("  Points: ").Append(this.Points).Append("\n");
          sb.Append("  PageNumber: ").Append(this.PageNumber).Append("\n");
          sb.Append("  AnnotationPosition: ").Append(this.AnnotationPosition).Append("\n");
          sb.Append("  SvgPath: ").Append(this.SvgPath).Append("\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  Replies: ").Append(this.Replies).Append("\n");
          sb.Append("  CreatedOn: ").Append(this.CreatedOn).Append("\n");
          sb.Append("  FontColor: ").Append(this.FontColor).Append("\n");
          sb.Append("  PenColor: ").Append(this.PenColor).Append("\n");
          sb.Append("  PenWidth: ").Append(this.PenWidth).Append("\n");
          sb.Append("  PenStyle: ").Append(this.PenStyle).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  FontFamily: ").Append(this.FontFamily).Append("\n");
          sb.Append("  FontSize: ").Append(this.FontSize).Append("\n");
          sb.Append("  Opacity: ").Append(this.Opacity).Append("\n");
          sb.Append("  Angle: ").Append(this.Angle).Append("\n");
          sb.Append("  ZIndex: ").Append(this.ZIndex).Append("\n");
          sb.Append("  Url: ").Append(this.Url).Append("\n");
          sb.Append("  ImagePath: ").Append(this.ImagePath).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
