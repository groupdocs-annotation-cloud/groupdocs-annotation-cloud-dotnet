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
        [TestCase(@"cells\ten-pages.xlsx", 8, 0)]
        [TestCase(@"diagram\ten-pages.vsd", 3, 5)]
        [TestCase(@"pdf\ten-pages.pdf", 8, 0)]
        [TestCase(@"slides\ten-pages.pptx", 3, 5)]
        [TestCase(@"words\ten-pages.docx", 0, 10)]
        [TestCase(@"cells\one-page-password.xlsx", 0, 0, null, false, false, null, "password", Ignore = "")]
        [TestCase(@"pdf\one-page-password.pdf", 0, 0, null, false, false, null, "password")]
        [TestCase(@"slides\one-page-password.pptx", 0, 0, null, false, false, null, "password", Ignore = "")]
        [TestCase(@"words\one-page-password.docx", 0, 0, null, false, false, null, "password", Ignore = "")]
        [Order(0)]
        public void TestGetPages(string filePath, int countPagesToConvert = 0, int pageNumber = 0, List<int?> pageNumbersToConvert = null, bool withoutAnnotations = false, bool enableCaching = false, string cacheStoragePath = null, string password = null)
        {
            GetPagesRequest request = new GetPagesRequest(filePath, countPagesToConvert, pageNumber, pageNumbersToConvert, withoutAnnotations, enableCaching, cacheStoragePath, password);
            var imagePages = PreviewApi.GetPages(request);
            Assert.NotNull(imagePages);
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
        [TestCase(@"cells\one-page-password.xlsx", Ignore = "")]
        [TestCase(@"pdf\one-page-password.pdf")]
        [TestCase(@"slides\one-page-password.pptx", Ignore = "")]
        [TestCase(@"words\one-page-password.docx", Ignore = "")]
        [Order(2)]
        public void TestDeletePages(string filePath)
        {
            PreviewApi.DeletePages(new DeletePagesRequest(filePath));
        }
    }
}
