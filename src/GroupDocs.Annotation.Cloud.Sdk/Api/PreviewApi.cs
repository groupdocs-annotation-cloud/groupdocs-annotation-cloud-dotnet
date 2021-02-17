// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PreviewApi.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
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
            // verify the required parameter 'fileInfo' is set
            if (request.fileInfo == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileInfo' when calling DeletePages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/preview/remove";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.fileInfo); // http body (model) parameter
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
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
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling GetPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/preview/create";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
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
          /// <param name="fileInfo">Document info to remove preview</param>
          public DeletePagesRequest(FileInfo fileInfo)             
          {
              this.fileInfo = fileInfo;
          }
          
          /// <summary>
          /// Document info to remove preview
          /// </summary>  
          public FileInfo fileInfo { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetPagesRequest.cs">
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
          /// <param name="options">Document preview options</param>
          public GetPagesRequest(PreviewOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Document preview options
          /// </summary>  
          public PreviewOptions options { get; set; }
    }
}
