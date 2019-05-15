// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="TestFiles.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Test.Api.Internal
{
    using System.Collections.Generic;

    public static class TestFiles
    {
        #region Cells
        public static readonly TestFile OnePageCells = new TestFile("one-page.xlsx", "cells");
        public static readonly TestFile OnePagePasswordCells = new TestFile("one-page-password.xlsx", "cells");
        public static readonly TestFile TenPagesCells = new TestFile("ten-pages.xlsx", "cells");
        #endregion

        #region Diagram
        public static readonly TestFile OnePageDiagram = new TestFile("one-page.vsd", "diagram");
        public static readonly TestFile TenPagesDiagram = new TestFile("ten-pages.vsd", "diagram");
        #endregion

        #region Email
        public static readonly TestFile OnePageEmail = new TestFile("one-page.emlx", "email");
        #endregion

        #region Html
        public static readonly TestFile OnePageHtml = new TestFile("one-page.html", "html");
        #endregion

        #region Images
        public static readonly TestFile OnePageBmp = new TestFile("one-page.bmp", "images");
        public static readonly TestFile OnePagePng = new TestFile("one-page.png", "images");
        #endregion

        #region Pdf
        public static readonly TestFile OnePagePdf = new TestFile("one-page.pdf", "pdf");
        public static readonly TestFile OnePagePasswordPdf = new TestFile("one-page-password.pdf", "pdf");
        public static readonly TestFile TenPagesPdf = new TestFile("ten-pages.pdf", "pdf");
        #endregion

        #region Slides
        public static readonly TestFile OnePageSlides = new TestFile("one-page.pptx", "slides");
        public static readonly TestFile OnePagePasswordSlides = new TestFile("one-page-password.pptx", "slides");
        public static readonly TestFile TenPagesSlides = new TestFile("ten-pages.pptx", "slides");
        #endregion

        #region Words
        public static readonly TestFile OnePageWords = new TestFile("one-page.docx", "words");
        public static readonly TestFile OnePagePasswordWords = new TestFile("one-page-password.docx", "words");
        public static readonly TestFile TenPagesWords = new TestFile("ten-pages.docx", "words");
        #endregion

        public static IEnumerable<TestFile> TestFilesList
        {
            get
            {
                yield return OnePageCells;
                yield return OnePagePasswordCells;
                yield return TenPagesCells;
                yield return OnePageDiagram;
                yield return TenPagesDiagram;
                yield return OnePageEmail;
                yield return OnePageHtml;
                yield return OnePageBmp;
                yield return OnePagePng;
                yield return OnePagePdf;
                yield return OnePagePasswordPdf;
                yield return TenPagesPdf;
                yield return OnePageSlides;
                yield return OnePagePasswordSlides;
                yield return TenPagesSlides;
                yield return OnePageWords;
                yield return OnePagePasswordWords;
                yield return TenPagesWords;
            }
        }
    }
}
