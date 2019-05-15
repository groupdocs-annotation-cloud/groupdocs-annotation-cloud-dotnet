// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotateApi.cs">
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
    public class AnnotateApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public AnnotateApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public AnnotateApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new AuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.configuration.Timeout);
        }                            

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAnnotationsRequest" /></param>
        public void DeleteAnnotations(DeleteAnnotationsRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling DeleteAnnotations");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation";
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
        /// Retrieves document with annotations 
        /// </summary>
        /// <param name="request">Request. <see cref="GetExportRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetExport(GetExportRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling GetExport");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/result";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "annotationTypes", request.annotationTypes);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "annotatedPages", request.annotatedPages);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "firstPage", request.firstPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "lastPage", request.lastPage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.password);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImportRequest" /></param>
        /// <returns><see cref="List<AnnotationInfo>"/></returns>
        public List<AnnotationInfo> GetImport(GetImportRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling GetImport");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                null);

            if (response != null)
            {
                return (List<AnnotationInfo>)SerializationHelper.Deserialize(response, typeof(List<AnnotationInfo>));
            }

            return null;
        }

        /// <summary>
        /// Retrieves PDF version of document 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPdfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream GetPdf(GetPdfRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling GetPdf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
        }

        /// <summary>
        /// Adds annotations to document 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAnnotationsRequest" /></param>
        public void PostAnnotations(PostAnnotationsRequest request)
        {
            // verify the required parameter 'filePath' is set
            if (request.filePath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'filePath' when calling PostAnnotations");
            }

            // verify the required parameter 'annotations' is set
            if (request.annotations == null) 
            {
                throw new ApiException(400, "Missing required parameter 'annotations' when calling PostAnnotations");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filePath", request.filePath);
            var postBody = SerializationHelper.Serialize(request.annotations); // http body (model) parameter
            this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeleteAnnotationsRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.DeleteAnnotations" /> operation.
    /// </summary>  
    public class DeleteAnnotationsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteAnnotationsRequest"/> class.
          /// </summary>        
          public DeleteAnnotationsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="DeleteAnnotationsRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          public DeleteAnnotationsRequest(string filePath)             
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
// <copyright company="Aspose Pty Ltd" file="GetExportRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.GetExport" /> operation.
    /// </summary>  
    public class GetExportRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetExportRequest"/> class.
          /// </summary>        
          public GetExportRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetExportRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified</param>
          /// <param name="annotatedPages">Indicates whether to export only annotated pages</param>
          /// <param name="firstPage">Determines number of first exported page</param>
          /// <param name="lastPage">Determines number of last exported page</param>
          /// <param name="password">Source document password</param>
          public GetExportRequest(string filePath, string annotationTypes = null, bool? annotatedPages = null, int? firstPage = null, int? lastPage = null, string password = null)             
          {
              this.filePath = filePath;
              this.annotationTypes = annotationTypes;
              this.annotatedPages = annotatedPages;
              this.firstPage = firstPage;
              this.lastPage = lastPage;
              this.password = password;
          }
          
          /// <summary>
          /// Document path in storage
          /// </summary>  
          public string filePath { get; set; }
          
          /// <summary>
          /// Annotation types that will be exported. All annotation types will be exported if not specified
          /// </summary>  
          public string annotationTypes { get; set; }
          
          /// <summary>
          /// Indicates whether to export only annotated pages
          /// </summary>  
          public bool? annotatedPages { get; set; }
          
          /// <summary>
          /// Determines number of first exported page
          /// </summary>  
          public int? firstPage { get; set; }
          
          /// <summary>
          /// Determines number of last exported page
          /// </summary>  
          public int? lastPage { get; set; }
          
          /// <summary>
          /// Source document password
          /// </summary>  
          public string password { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetImportRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.GetImport" /> operation.
    /// </summary>  
    public class GetImportRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetImportRequest"/> class.
          /// </summary>        
          public GetImportRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetImportRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          public GetImportRequest(string filePath)             
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
// <copyright company="Aspose Pty Ltd" file="GetPdfRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.GetPdf" /> operation.
    /// </summary>  
    public class GetPdfRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetPdfRequest"/> class.
          /// </summary>        
          public GetPdfRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetPdfRequest"/> class.
          /// </summary>
          /// <param name="filePath">Path to document in storage</param>
          public GetPdfRequest(string filePath)             
          {
              this.filePath = filePath;
          }
          
          /// <summary>
          /// Path to document in storage
          /// </summary>  
          public string filePath { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostAnnotationsRequest.cs">
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
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.PostAnnotations" /> operation.
    /// </summary>  
    public class PostAnnotationsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="PostAnnotationsRequest"/> class.
          /// </summary>        
          public PostAnnotationsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="PostAnnotationsRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          /// <param name="annotations">Array of annotation descriptions</param>
          public PostAnnotationsRequest(string filePath, List<AnnotationInfo> annotations)             
          {
              this.filePath = filePath;
              this.annotations = annotations;
          }
          
          /// <summary>
          /// Document path in storage
          /// </summary>  
          public string filePath { get; set; }
          
          /// <summary>
          /// Array of annotation descriptions
          /// </summary>  
          public List<AnnotationInfo> annotations { get; set; }
    }
}
