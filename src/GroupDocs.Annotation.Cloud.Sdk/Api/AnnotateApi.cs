// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotateApi.cs">
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
        /// Adds annotations to document and saves output file into cloud storage 
        /// </summary>
        /// <param name="request">Request. <see cref="AnnotateRequest" /></param>
        /// <returns><see cref="AnnotationApiLink"/></returns>
        public AnnotationApiLink Annotate(AnnotateRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling Annotate");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/add";
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
                return (AnnotationApiLink)SerializationHelper.Deserialize(response, typeof(AnnotationApiLink));
            }

            return null;
        }

        /// <summary>
        /// Adds annotations to document and returns output file 
        /// </summary>
        /// <param name="request">Request. <see cref="AnnotateDirectRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        public System.IO.Stream AnnotateDirect(AnnotateDirectRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling AnnotateDirect");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/add";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.options); // http body (model) parameter
            return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <param name="request">Request. <see cref="ExtractRequest" /></param>
        /// <returns><see cref="List<AnnotationInfo>"/></returns>
        public List<AnnotationInfo> Extract(ExtractRequest request)
        {
            // verify the required parameter 'fileInfo' is set
            if (request.fileInfo == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileInfo' when calling Extract");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/extract";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.fileInfo); // http body (model) parameter
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                null);

            if (response != null)
            {
                return (List<AnnotationInfo>)SerializationHelper.Deserialize(response, typeof(List<AnnotationInfo>));
            }

            return null;
        }

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <param name="request">Request. <see cref="RemoveAnnotationsRequest" /></param>
        /// <returns><see cref="AnnotationApiLink"/></returns>
        public AnnotationApiLink RemoveAnnotations(RemoveAnnotationsRequest request)
        {
            // verify the required parameter 'options' is set
            if (request.options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling RemoveAnnotations");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetServerUrl() + "/annotation/remove";
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
                return (AnnotationApiLink)SerializationHelper.Deserialize(response, typeof(AnnotationApiLink));
            }

            return null;
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotateRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.Annotate" /> operation.
    /// </summary>  
    public class AnnotateRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="AnnotateRequest"/> class.
          /// </summary>        
          public AnnotateRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="AnnotateRequest"/> class.
          /// </summary>
          /// <param name="options">Annotation options</param>
          public AnnotateRequest(AnnotateOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Annotation options
          /// </summary>  
          public AnnotateOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="AnnotateDirectRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.AnnotateDirect" /> operation.
    /// </summary>  
    public class AnnotateDirectRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="AnnotateDirectRequest"/> class.
          /// </summary>        
          public AnnotateDirectRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="AnnotateDirectRequest"/> class.
          /// </summary>
          /// <param name="options">Annotation options</param>
          public AnnotateDirectRequest(AnnotateOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Annotation options
          /// </summary>  
          public AnnotateOptions options { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ExtractRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.Extract" /> operation.
    /// </summary>  
    public class ExtractRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="ExtractRequest"/> class.
          /// </summary>        
          public ExtractRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="ExtractRequest"/> class.
          /// </summary>
          /// <param name="fileInfo">Input file information</param>
          public ExtractRequest(FileInfo fileInfo)             
          {
              this.fileInfo = fileInfo;
          }
          
          /// <summary>
          /// Input file information
          /// </summary>  
          public FileInfo fileInfo { get; set; }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="RemoveAnnotationsRequest.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Model.Requests 
{
    using System.Collections.Generic;
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotateApi.RemoveAnnotations" /> operation.
    /// </summary>  
    public class RemoveAnnotationsRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveAnnotationsRequest"/> class.
          /// </summary>        
          public RemoveAnnotationsRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="RemoveAnnotationsRequest"/> class.
          /// </summary>
          /// <param name="options">Remove annotations options</param>
          public RemoveAnnotationsRequest(RemoveOptions options)             
          {
              this.options = options;
          }
          
          /// <summary>
          /// Remove annotations options
          /// </summary>  
          public RemoveOptions options { get; set; }
    }
}
