// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotationInfo.cs">
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
    /// Describes annotation properties
    /// </summary>
    [DataContract]
    public partial class AnnotationInfo
    {
        /// <summary>
        /// Gets or sets the annotation type
        /// </summary>
        /// <value>Gets or sets the annotation type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Text for "Text"
            /// </summary>
            [EnumMember(Value = "Text")]
            Text,
            
            /// <summary>
            /// Enum Area for "Area"
            /// </summary>
            [EnumMember(Value = "Area")]
            Area,
            
            /// <summary>
            /// Enum Point for "Point"
            /// </summary>
            [EnumMember(Value = "Point")]
            Point,
            
            /// <summary>
            /// Enum TextStrikeout for "TextStrikeout"
            /// </summary>
            [EnumMember(Value = "TextStrikeout")]
            TextStrikeout,
            
            /// <summary>
            /// Enum Polyline for "Polyline"
            /// </summary>
            [EnumMember(Value = "Polyline")]
            Polyline,
            
            /// <summary>
            /// Enum TextField for "TextField"
            /// </summary>
            [EnumMember(Value = "TextField")]
            TextField,
            
            /// <summary>
            /// Enum Watermark for "Watermark"
            /// </summary>
            [EnumMember(Value = "Watermark")]
            Watermark,
            
            /// <summary>
            /// Enum TextReplacement for "TextReplacement"
            /// </summary>
            [EnumMember(Value = "TextReplacement")]
            TextReplacement,
            
            /// <summary>
            /// Enum Arrow for "Arrow"
            /// </summary>
            [EnumMember(Value = "Arrow")]
            Arrow,
            
            /// <summary>
            /// Enum TextRedaction for "TextRedaction"
            /// </summary>
            [EnumMember(Value = "TextRedaction")]
            TextRedaction,
            
            /// <summary>
            /// Enum ResourcesRedaction for "ResourcesRedaction"
            /// </summary>
            [EnumMember(Value = "ResourcesRedaction")]
            ResourcesRedaction,
            
            /// <summary>
            /// Enum TextUnderline for "TextUnderline"
            /// </summary>
            [EnumMember(Value = "TextUnderline")]
            TextUnderline,
            
            /// <summary>
            /// Enum Distance for "Distance"
            /// </summary>
            [EnumMember(Value = "Distance")]
            Distance,
            
            /// <summary>
            /// Enum Ellipse for "Ellipse"
            /// </summary>
            [EnumMember(Value = "Ellipse")]
            Ellipse
        }

        /// <summary>
        /// Gets or sets the annotation type
        /// </summary>
        /// <value>Gets or sets the annotation type</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Gets or sets the annotation access
        /// </summary>
        /// <value>Gets or sets the annotation access</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        {
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private
        }

        /// <summary>
        /// Gets or sets the annotation access
        /// </summary>
        /// <value>Gets or sets the annotation access</value>
        [DataMember(Name="Access", EmitDefaultValue=false)]
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// Gets or sets the unique identifier
        /// </summary>
        /// <value>Gets or sets the unique identifier</value>
        [DataMember(Name="Guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or sets the document unique identifier
        /// </summary>
        /// <value>Gets or sets the document unique identifier</value>
        [DataMember(Name="DocumentGuid", EmitDefaultValue=false)]
        public long? DocumentGuid { get; set; }

        /// <summary>
        /// Gets or sets the annotation text
        /// </summary>
        /// <value>Gets or sets the annotation text</value>
        [DataMember(Name="Text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the creator unique identifier
        /// </summary>
        /// <value>Gets or sets the creator unique identifier</value>
        [DataMember(Name="CreatorGuid", EmitDefaultValue=false)]
        public string CreatorGuid { get; set; }

        /// <summary>
        /// Gets or sets the name of the creator
        /// </summary>
        /// <value>Gets or sets the name of the creator</value>
        [DataMember(Name="CreatorName", EmitDefaultValue=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// Gets or sets the creator&#39;s email
        /// </summary>
        /// <value>Gets or sets the creator&#39;s email</value>
        [DataMember(Name="CreatorEmail", EmitDefaultValue=false)]
        public string CreatorEmail { get; set; }

        /// <summary>
        /// Gets or sets the box where annotation will be placed
        /// </summary>
        /// <value>Gets or sets the box where annotation will be placed</value>
        [DataMember(Name="Box", EmitDefaultValue=false)]
        public Rectangle Box { get; set; }

        /// <summary>
        /// Gets or sets the number of page where annotation will be placed
        /// </summary>
        /// <value>Gets or sets the number of page where annotation will be placed</value>
        [DataMember(Name="PageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the annotation position
        /// </summary>
        /// <value>Gets or sets the annotation position</value>
        [DataMember(Name="AnnotationPosition", EmitDefaultValue=false)]
        public Point AnnotationPosition { get; set; }

        /// <summary>
        /// Gets or sets the annotation SVG path
        /// </summary>
        /// <value>Gets or sets the annotation SVG path</value>
        [DataMember(Name="SvgPath", EmitDefaultValue=false)]
        public string SvgPath { get; set; }



        /// <summary>
        /// Gets or sets the array of annotation replies
        /// </summary>
        /// <value>Gets or sets the array of annotation replies</value>
        [DataMember(Name="Replies", EmitDefaultValue=false)]
        public List<AnnotationReplyInfo> Replies { get; set; }

        /// <summary>
        /// Gets or sets the annotation created on date
        /// </summary>
        /// <value>Gets or sets the annotation created on date</value>
        [DataMember(Name="CreatedOn", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s font color
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s font color</value>
        [DataMember(Name="FontColor", EmitDefaultValue=false)]
        public int? FontColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s pen color
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s pen color</value>
        [DataMember(Name="PenColor", EmitDefaultValue=false)]
        public int? PenColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s pen width
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s pen width</value>
        [DataMember(Name="PenWidth", EmitDefaultValue=false)]
        public int? PenWidth { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s pen style
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s pen style</value>
        [DataMember(Name="PenStyle", EmitDefaultValue=false)]
        public int? PenStyle { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s background color 
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s background color </value>
        [DataMember(Name="BackgroundColor", EmitDefaultValue=false)]
        public int? BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s field text
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s field text</value>
        [DataMember(Name="FieldText", EmitDefaultValue=false)]
        public string FieldText { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s font family
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s font family</value>
        [DataMember(Name="FontFamily", EmitDefaultValue=false)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s font size 
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s font size </value>
        [DataMember(Name="FontSize", EmitDefaultValue=false)]
        public double? FontSize { get; set; }

        /// <summary>
        /// Gets or sets the annotation&#39;s opacity
        /// </summary>
        /// <value>Gets or sets the annotation&#39;s opacity</value>
        [DataMember(Name="Opacity", EmitDefaultValue=false)]
        public double? Opacity { get; set; }

        /// <summary>
        /// Gets or sets the watermark annotation&#39;s rotation angle
        /// </summary>
        /// <value>Gets or sets the watermark annotation&#39;s rotation angle</value>
        [DataMember(Name="Angle", EmitDefaultValue=false)]
        public double? Angle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnotationInfo {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  DocumentGuid: ").Append(DocumentGuid).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  CreatorGuid: ").Append(CreatorGuid).Append("\n");
            sb.Append("  CreatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
            sb.Append("  Box: ").Append(Box).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  AnnotationPosition: ").Append(AnnotationPosition).Append("\n");
            sb.Append("  SvgPath: ").Append(SvgPath).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Replies: ").Append(Replies).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  PenColor: ").Append(PenColor).Append("\n");
            sb.Append("  PenWidth: ").Append(PenWidth).Append("\n");
            sb.Append("  PenStyle: ").Append(PenStyle).Append("\n");
            sb.Append("  BackgroundColor: ").Append(BackgroundColor).Append("\n");
            sb.Append("  FieldText: ").Append(FieldText).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Opacity: ").Append(Opacity).Append("\n");
            sb.Append("  Angle: ").Append(Angle).Append("\n");
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
