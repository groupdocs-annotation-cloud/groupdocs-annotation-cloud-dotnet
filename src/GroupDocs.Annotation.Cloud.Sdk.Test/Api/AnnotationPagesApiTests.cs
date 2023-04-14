// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd">
//  Copyright (c) 2003-2023 Aspose Pty Ltd
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
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace GroupDocs.Annotation.Cloud.Sdk.Test.Api
{
    public class AnnotationPagesApiTests : BaseApiTest
    {
        [TestCase(@"cells\one-page.xlsx")]
        [TestCase(@"diagram\one-page.vsd")]
        [TestCase(@"email\one-page.emlx")]
        [TestCase(@"images\one-page.png")]
        [TestCase(@"pdf\one-page.pdf")]
        [TestCase(@"slides\one-page.pptx")]
        [TestCase(@"words\one-page.docx")]
        [TestCase(@"cells\ten-pages.xlsx", PreviewOptions.FormatEnum.JPEG)]
        [TestCase(@"diagram\ten-pages.vsd")]
        [TestCase(@"pdf\ten-pages.pdf")]
        [TestCase(@"slides\ten-pages.pptx")]
        [TestCase(@"words\ten-pages.docx")]
        [TestCase(@"cells\one-page-password.xlsx", null, null, false, 0, 0, false, "password")]
        [TestCase(@"pdf\one-page-password.pdf", null, null, false, 0, 0, false, "password")]
        [TestCase(@"slides\one-page-password.pptx", null, null, false, 0, 0, false, "password")]
        [TestCase(@"words\one-page-password.docx", null, null, false, 0, 0, false, "password")]
        [Order(0)]
        public void TestGetPages(string filePath, PreviewOptions.FormatEnum? format = null, List<int?> pageNumbersToConvert = null,
            bool withoutAnnotations = false, int width = 0, int height = 0,
            bool renderComments = false, string password = null)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath,
                Password = password
            };
            var options = new PreviewOptions
            {
                FileInfo = fileInfo,
                Format = format,
                Height = height,
                Width = width,
                PageNumbers = pageNumbersToConvert,
                RenderComments = renderComments
            };
            var request = new GetPagesRequest(options);
            var result = PreviewApi.GetPages(request);
            Assert.NotNull(result);
            Assert.Greater(result.TotalCount, 0);
            Assert.NotNull(result.Entries);
            Assert.Greater(result.Entries.Count, 0);
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
        [Order(1)]
        public void TestDeletePages(string filePath)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath
            };
            PreviewApi.DeletePages(new DeletePagesRequest(fileInfo));
        }
    }
}
