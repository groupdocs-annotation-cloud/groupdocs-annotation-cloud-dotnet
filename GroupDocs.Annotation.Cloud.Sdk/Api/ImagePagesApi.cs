// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImagePagesApi.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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

namespace GroupDocs.Annotation.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    using GroupDocs.Annotation.Cloud.Sdk.Api;
    using GroupDocs.Annotation.Cloud.Sdk.Internal;
    using GroupDocs.Annotation.Cloud.Sdk.Internal.RequestHandlers;
    using GroupDocs.Annotation.Cloud.Sdk.Model;
    using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;
    
    
    /// <summary>
    /// GroupDocs.Annotation for Cloud API.
    /// </summary>
    public class ImagePagesApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePagesApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public ImagePagesApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePagesApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public ImagePagesApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Removes document&#39;s pages as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeletePagesRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DeletePages(DeletePagesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling DeletePages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/annotation/{name}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                    "DELETE", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return response;
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Downloads document&#39;s page as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageRequest" /></param> 
        /// <returns><see cref="ImagePage"/></returns>            
        public ImagePage GetPage(GetPageRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPage");
            }

            // verify the required parameter 'pageNumber' is set
            if (request.PageNumber == null) 
            {
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling GetPage");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/annotation/{name}/image/pages/{pageNumber}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageNumber", request.PageNumber);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ImagePage)SerializationHelper.Deserialize(response, typeof(ImagePage));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Retrieves document&#39;s pages as images. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPagesRequest" /></param> 
        /// <returns><see cref="ImagePages"/></returns>            
        public ImagePages GetPages(GetPagesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/annotation/{name}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ImagePages)SerializationHelper.Deserialize(response, typeof(ImagePages));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Creates document&#39;s pages as image. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostPagesRequest" /></param> 
        /// <returns><see cref="ImagePages"/></returns>            
        public ImagePages PostPages(PostPagesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostPages");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/annotation/{name}/image/pages";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "password", request.Password);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (ImagePages)SerializationHelper.Deserialize(response, typeof(ImagePages));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="DeletePagesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  using GroupDocs.Annotation.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotationApi.DeletePages" /> operation.
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
        /// <param name="name">The document name.</param>
        /// <param name="folder">The folder name.</param>
        public DeletePagesRequest(string name, string folder = null)             
        {
            this.Name = name;
            this.Folder = folder;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The folder name.
        /// </summary>  
        public string Folder { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetPageRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  using GroupDocs.Annotation.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotationApi.GetPage" /> operation.
  /// </summary>  
  public class GetPageRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPageRequest"/> class.
        /// </summary>        
        public GetPageRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPageRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="folder">The folder name.</param>
        public GetPageRequest(string name, int? pageNumber, string folder = null)             
        {
            this.Name = name;
            this.PageNumber = pageNumber;
            this.Folder = folder;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>  
        public int? PageNumber { get; set; }

        /// <summary>
        /// The folder name.
        /// </summary>  
        public string Folder { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetPagesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  using GroupDocs.Annotation.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotationApi.GetPages" /> operation.
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
        /// <param name="name">The document name.</param>
        /// <param name="folder">The folder name.</param>
        public GetPagesRequest(string name, string folder = null)             
        {
            this.Name = name;
            this.Folder = folder;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The folder name.
        /// </summary>  
        public string Folder { get; set; }
  }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="PostPagesRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
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
  using GroupDocs.Annotation.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.AnnotationApi.PostPages" /> operation.
  /// </summary>  
  public class PostPagesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostPagesRequest"/> class.
        /// </summary>        
        public PostPagesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostPagesRequest"/> class.
        /// </summary>
        /// <param name="name">The document name.</param>
        /// <param name="folder">The folder name.</param>
        /// <param name="password">The document password.</param>
        public PostPagesRequest(string name, string folder = null, string password = null)             
        {
            this.Name = name;
            this.Folder = folder;
            this.Password = password;
        }

        /// <summary>
        /// The document name.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The folder name.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The document password.
        /// </summary>  
        public string Password { get; set; }
  }
}
