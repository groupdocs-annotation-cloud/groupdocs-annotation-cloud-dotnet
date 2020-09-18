// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PreviewApi.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.IO;
    using GroupDocs.Annotation.Cloud.Sdk.Client;
    using GroupDocs.Annotation.Cloud.Sdk.Client.RequestHandlers;
    using GroupDocs.Annotation.Cloud.Sdk.Model;
    using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// GroupDocs.Annotation.Cloud.Sdk API.
    /// </summary>
    public class PreviewApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public PreviewApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public PreviewApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Removes document&#39;s pages image representations 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePagesRequest" /></param>
        public void DeletePages(DeletePagesRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling DeletePages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Generates image representations from documents pages 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPagesRequest" /></param>
        /// <returns><see cref="PageImages"/></returns>
        public PageImages GetPages(GetPagesRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling GetPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "countPagesToConvert", request.countPagesToConvert);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.pageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumbersToConvert", request.pageNumbersToConvert);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "withoutAnnotations", request.withoutAnnotations);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableCaching", request.enableCaching);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cacheStoragePath", request.cacheStoragePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.password);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (PageImages)SerializationHelper.Deserialize(response, typeof(PageImages));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeletePagesRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.PreviewApi.DeletePages" /> operation.
    /// </summary>  
    public class DeletePagesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeletePagesRequest"/> class.
          /// </summary>        
          public DeletePagesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeletePagesRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          public DeletePagesRequest(string filePath)             
          {
              this.filePath = filePath;
          }
          
          /// <summary>
          /// Document path in storage
          /// </summary>  
          public string filePath { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetPagesRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.PreviewApi.GetPages" /> operation.
    /// </summary>  
    public class GetPagesRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetPagesRequest"/> class.
          /// </summary>        
          public GetPagesRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetPagesRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          /// <param name="countPagesToConvert">The count pages to convert</param>
          /// <param name="pageNumber">The start page number</param>
          /// <param name="pageNumbersToConvert">The list of page numbers to convert</param>
          /// <param name="withoutAnnotations">If true returns specific pages without annotations</param>
          /// <param name="enableCaching">Indicates whether to use previously cached document or not</param>
          /// <param name="cacheStoragePath">The cache storage path</param>
          /// <param name="password">Source document opening password</param>
          public GetPagesRequest(string filePath, int? countPagesToConvert = null, int? pageNumber = null, List<int?> pageNumbersToConvert = null, bool? withoutAnnotations = null, bool? enableCaching = null, string cacheStoragePath = null, string password = null)             
          {
              this.filePath = filePath;
              this.countPagesToConvert = countPagesToConvert;
              this.pageNumber = pageNumber;
              this.pageNumbersToConvert = pageNumbersToConvert;
              this.withoutAnnotations = withoutAnnotations;
              this.enableCaching = enableCaching;
              this.cacheStoragePath = cacheStoragePath;
              this.password = password;
          }
          
          /// <summary>
          /// Document path in storage
          /// </summary>  
          public string filePath { get; set; }
          
          /// <summary>
          /// The count pages to convert
          /// </summary>  
          public int? countPagesToConvert { get; set; }
          
          /// <summary>
          /// The start page number
          /// </summary>  
          public int? pageNumber { get; set; }
          
          /// <summary>
          /// The list of page numbers to convert
          /// </summary>  
          public List<int?> pageNumbersToConvert { get; set; }
          
          /// <summary>
          /// If true returns specific pages without annotations
          /// </summary>  
          public bool? withoutAnnotations { get; set; }
          
          /// <summary>
          /// Indicates whether to use previously cached document or not
          /// </summary>  
          public bool? enableCaching { get; set; }
          
          /// <summary>
          /// The cache storage path
          /// </summary>  
          public string cacheStoragePath { get; set; }
          
          /// <summary>
          /// Source document opening password
          /// </summary>  
          public string password { get; set; }
    }
}
