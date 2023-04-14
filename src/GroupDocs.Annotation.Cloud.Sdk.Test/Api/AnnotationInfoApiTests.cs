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

using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
using GroupDocs.Annotation.Cloud.Sdk.Test.Api.Internal;
using NUnit.Framework;

namespace GroupDocs.Annotation.Cloud.Sdk.Test.Api
{
    public class AnnotationInfoApiTests : BaseApiTest
    {
        [Test]
        public void TestGetInfoReturnsMissingFileInfo()
        {
            // Arrange
            var request = new GetInfoRequest();

            // Act & Assert    
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });

            Assert.AreEqual("Missing required parameter 'fileInfo' when calling GetInfo", ex.Message);
        }

        [Test]
        public void TestGetInfoReturnsFileNotFound()
        {
            // Arrange
            var fileInfo = new Model.FileInfo
            {
                FilePath = TestFiles.NotExist.FullName,
                Password = TestFiles.NotExist.Password
            };
            var request = new GetInfoRequest(fileInfo);

            // Act & Assert
            var ex = Assert.Throws<ApiException>(() => {
                InfoApi.GetInfo(request);
            });
            Assert.AreEqual("Specified file not found", ex.Message);
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
        [TestCase(@"cells\one-page-password.xlsx", "password")]
        [TestCase(@"pdf\one-page-password.pdf", "password")]
        [TestCase(@"slides\one-page-password.pptx", "password")]
        [TestCase(@"words\one-page-password.docx", "password")]
        public void TestGetInfo(string filePath, string password = null)
        {
            var fileInfo = new Model.FileInfo
            {
                FilePath = filePath,
                Password = password
            };
            var request = new GetInfoRequest(fileInfo);
            var info = InfoApi.GetInfo(request);
            Assert.NotNull(info);
            Assert.AreEqual(filePath, info.Path);
        }
    }
}
