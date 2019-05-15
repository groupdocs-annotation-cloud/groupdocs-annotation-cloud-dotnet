// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
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
        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"email\one-page.emlx")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\ten-pages.xlsx")]
        [TestCase(@"diagram\ten-pages.vsd")]
        [TestCase(@"pdf\ten-pages.pdf")]
        [TestCase(@"slides\ten-pages.pptx")]
        [TestCase(@"words\ten-pages.docx")]
        [TestCase(@"cells\one-page-password.xlsx")]
        [TestCase(@"pdf\one-page-password.pdf")]
        [TestCase(@"slides\one-page-password.pptx")]
        [TestCase(@"words\one-page-password.docx")]
        [Order(1)]
        public void TestGetImport(string filePath)
        {
            var annotations = AnnotateApi.GetImport(new GetImportRequest(filePath));
            Assert.AreNotEqual(null, annotations);
            Assert.IsInstanceOf(typeof(AnnotationInfo), annotations[0]);
        }

        [TestCase(@"cells\one-page.xlsx", Ignore = "")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"email\one-page.emlx")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\ten-pages.xlsx", "Area,Point", true, 2, 5, Ignore = "")]
        [TestCase(@"diagram\ten-pages.vsd", "Area,Point", true, 2, 5)]
        [TestCase(@"pdf\ten-pages.pdf", "Area,Point", true, 2, 5)]
        [TestCase(@"slides\ten-pages.pptx", "Area,Point", true, 2, 5)]
        [TestCase(@"words\ten-pages.docx", "Area,Point", true, 2, 5)]
        [TestCase(@"cells\one-page-password.xlsx", null, false, -1, -1, "password", Ignore = "")]
        [TestCase(@"pdf\one-page-password.pdf", null, false, -1, -1, "password")]
        [TestCase(@"slides\one-page-password.pptx", null, false, -1, -1, "password")]
        [TestCase(@"words\one-page-password.docx", null, false, -1, -1, "password")]
        [Order(2)]
        public void TestGetExport(string filePath, string annotationTypes = null, bool annotatedPages = false, int firstPage = -1, int lastPage = -1, string password = null)
        {
            GetExportRequest request = new GetExportRequest(filePath, annotationTypes, annotatedPages, firstPage, lastPage, password);
            var result = AnnotateApi.GetExport(request);
            Assert.IsNotNull(result);
            Assert.IsInstanceOf(typeof(Stream), result);
        }

        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"email\one-page.emlx")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\ten-pages.xlsx")]
        [TestCase(@"diagram\ten-pages.vsd")]
        [TestCase(@"pdf\ten-pages.pdf")]
        [TestCase(@"slides\ten-pages.pptx")]
        [TestCase(@"words\ten-pages.docx")]
        [TestCase(@"cells\one-page-password.xlsx")]
        [TestCase(@"pdf\one-page-password.pdf")]
        [TestCase(@"slides\one-page-password.pptx")]
        [TestCase(@"words\one-page-password.docx")]
        [Order(3)]
        public void TestDeleteAnnotations(string filePath)
        {
            AnnotateApi.DeleteAnnotations(new DeleteAnnotationsRequest(filePath));
        }

        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"email\one-page.emlx")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\one-page-password.xlsx")]
        [TestCase(@"pdf\one-page-password.pdf")]
        [TestCase(@"slides\one-page-password.pptx")]
        [TestCase(@"words\one-page-password.docx")]
        [Order(0)]
        public void TestPostAnnotations(string filePath)
        {
            var request = new PostAnnotationsRequest(filePath, GetAnnotationsTestBody());
            AnnotateApi.PostAnnotations(request);
        }

        [TestCase(@"cells\ten-pages.xlsx")]
        [TestCase(@"diagram\ten-pages.vsd")]
        [TestCase(@"pdf\ten-pages.pdf")]
        [TestCase(@"slides\ten-pages.pptx")]
        [TestCase(@"words\ten-pages.docx")]
        [Order(0)]
        public void TestPostAnnotationsManyPages(string filePath)
        {
            var request = new PostAnnotationsRequest(filePath, GetAnnotationsTestBodyManyPages());
            AnnotateApi.PostAnnotations(request);
        }

        private List<AnnotationInfo> GetAnnotationsTestBody()
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

        private List<AnnotationInfo> GetAnnotationsTestBodyManyPages()
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
