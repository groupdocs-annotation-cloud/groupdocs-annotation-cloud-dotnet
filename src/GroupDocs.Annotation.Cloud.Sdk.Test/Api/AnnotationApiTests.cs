// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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

using System.Collections.Generic;
using System.IO;
using System.Linq;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Annotation.Cloud.Sdk.Test.Api
{
    public class AnnotationApiTests : BaseApiTest
    {
        [TestCase(@"input\input.docx")]
        [TestCase(@"input\input.xlsx")]
        [TestCase(@"input\input.eml")]
        [TestCase(@"input\input.html")]
        [TestCase(@"input\input.pdf")]
        [TestCase(@"input\input.png")]
        [TestCase(@"input\input.pptx")]
        [TestCase(@"input\input.vsdx")]
        public void TestExtract(string filePath)
        {
            var fileInfo = new Model.FileInfo {FilePath = filePath};
            var annotations = AnnotateApi.Extract(new ExtractRequest(fileInfo));
            Assert.AreNotEqual(null, annotations);
            Assert.Greater(annotations.Count, 0);
            Assert.IsInstanceOf(typeof(AnnotationInfo), annotations[0]);
        }

        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\ten-pages.xlsx", "Area,Point", true, 2, 5)]
        [TestCase(@"diagram\ten-pages.vsd", "Area,Point", true, 2, 5)]
        [TestCase(@"pdf\ten-pages.pdf", "Area,Point", true, 1, 2)]
        [TestCase(@"slides\ten-pages.pptx", "Area,Point", true, 2, 5)]
        [TestCase(@"words\ten-pages.docx", "Area,Point", true, 2, 5)]
        [TestCase(@"cells\one-page-password.xlsx", null, false, -1, -1, "password")]
        [TestCase(@"pdf\one-page-password.pdf", null, false, -1, -1, "password")]
        [TestCase(@"slides\one-page-password.pptx", null, false, -1, -1, "password")]
        [TestCase(@"words\one-page-password.docx", null, false, -1, -1, "password")]
        public void TestAddDirect(string filePath, string annotationTypes = null, bool annotatedPages = false, int firstPage = -1, int lastPage = -1, string password = null)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath,
                Password = password
            };
            var options = new AnnotateOptions
            {
                FileInfo = fileInfo,
                Annotations = GetAnnotations(),
                FirstPage = firstPage,
                LastPage = lastPage,
                OnlyAnnotatedPages = annotatedPages
            };
            var request = new AnnotateDirectRequest(options);
            var result = AnnotateApi.AnnotateDirect(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(Stream), result);
        }

        [TestCase(@"input\input.docx")]
        [TestCase(@"input\input.xlsx")]
        [TestCase(@"input\input.eml")]
        [TestCase(@"input\input.html")]
        [TestCase(@"input\input.pdf")]
        [TestCase(@"input\input.png")]
        [TestCase(@"input\input.pptx")]
        [TestCase(@"input\input.vsdx")]
        public void TestRemoveAnnotations(string filePath)
        {
            var options = new RemoveOptions
            {
                FileInfo = new Model.FileInfo {FilePath = filePath},
                AnnotationIds = new List<int?> {1, 2, 3},
                OutputPath = $"{DefaultOutputPath}/{Path.GetFileName(filePath)}"
            };
            var result = AnnotateApi.RemoveAnnotations(new RemoveAnnotationsRequest(options));
            Assert.NotNull(result);
            Assert.IsNotEmpty(result.Href);
        }

        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\one-page-password.xlsx", "password")]
        [TestCase(@"pdf\one-page-password.pdf", "password")]
        [TestCase(@"slides\one-page-password.pptx", "password")]
        [TestCase(@"words\one-page-password.docx", "password")]
        public void TestAddAnnotations(string filePath, string password = null)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath,
                Password = password
            };
            var options = new AnnotateOptions
            {
                FileInfo = fileInfo,
                Annotations = GetAnnotations(),
                OutputPath = $"{DefaultOutputPath}/{Path.GetFileName(filePath)}"
            };
            var request = new AnnotateRequest(options);
            var result = AnnotateApi.Annotate(request);
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result.Href);
        }

        [TestCase(@"cells\ten-pages.xlsx")]
        [TestCase(@"diagram\ten-pages.vsd")]
        [TestCase(@"pdf\ten-pages.pdf")]
        [TestCase(@"slides\ten-pages.pptx")]
        [TestCase(@"words\ten-pages.docx")]
        [Order(0)]
        public void TestAddAnnotationsManyPages(string filePath)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath
            };
            var options = new AnnotateOptions
            {
                FileInfo = fileInfo,
                Annotations = GetAnnotationsManyPages(),
                OutputPath = $"{DefaultOutputPath}/{Path.GetFileName(filePath)}"
            };
            var request = new AnnotateRequest(options);
            var result = AnnotateApi.Annotate(request);
            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result.Href);
        }

        private static List<AnnotationInfo> GetAnnotations()
        {
            AnnotationInfo[] annotations = {
                new AnnotationInfo
                {
                    AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                    Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                    PageNumber = 0,
                    PenColor = 1201033,
                    PenStyle = 0,
                    PenWidth = 1,
                    Type = AnnotationInfo.TypeEnum.Area,
                    CreatorName = "Anonym A."
                }
            };
            return annotations.ToList();
        }

        private List<AnnotationInfo> GetAnnotationsManyPages()
        {
            AnnotationInfo[] annotations = {
                new AnnotationInfo
                {
                    AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                    Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                    PageNumber = 0,
                    PenColor = 1201033,
                    PenStyle = 0,
                    PenWidth = 1,
                    Type = AnnotationInfo.TypeEnum.Distance,
                    CreatorName = "Anonym A."
                },
                new AnnotationInfo
                {
                    AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                    Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                    PageNumber = 2,
                    PenColor = 1201033,
                    PenStyle = 0,
                    PenWidth = 1,
                    Type = AnnotationInfo.TypeEnum.Area,
                    CreatorName = "Anonym A."
                },
                new AnnotationInfo
                {
                    AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                    Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                    PageNumber = 4,
                    Type = AnnotationInfo.TypeEnum.Point,
                    CreatorName = "Anonym A."
                },
                new AnnotationInfo
                {
                    AnnotationPosition = new Point { X = 852, Y = 59.388262910798119 },
                    Box = new Rectangle { X = 375.89276123046875, Y = 59.388263702392578, Width = 88.7330551147461, Height = 37.7290153503418 },
                    PageNumber = 5,
                    PenColor = 1201033,
                    PenStyle = 0,
                    PenWidth = 1,
                    Type = AnnotationInfo.TypeEnum.Arrow,
                    CreatorName = "Anonym A."
                }
            };
            return annotations.ToList();
        }
    }
}
