// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="InfoApi.cs">
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

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp.Portable;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;
using GroupDocs.Annotation.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Annotation.Cloud.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInfoApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>DocumentInfo</returns>
        DocumentInfo GetInfo(GetInfoRequest request);

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>ApiResponse of DocumentInfo</returns>
        ApiResponse<DocumentInfo> GetInfoWithHttpInfo (GetInfoRequest request);
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        FormatsResult GetSupportedFileFormats();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of DocumentInfo</returns>
        System.Threading.Tasks.Task<DocumentInfo> GetInfoAsync(GetInfoRequest request);

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of ApiResponse (DocumentInfo)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentInfo>> GetInfoAsyncWithHttpInfo(GetInfoRequest request);
        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync();

        /// <summary>
        /// Retrieves supported file formats list 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InfoApi : IInfoApi
    {
        private GroupDocs.Annotation.Cloud.Sdk.Client.ExceptionFactoryDelegate _exceptionFactory = GroupDocs.Annotation.Cloud.Sdk.Client.ExceptionFactory.Default;
        private GroupDocs.Annotation.Cloud.Sdk.Client.Configuration _configuration;
        private GroupDocs.Annotation.Cloud.Sdk.Client.ApiClient _apiClient;
        private GroupDocs.Annotation.Cloud.Sdk.Client.IAuthorization _authorization;
        private List<Parameter> _defaultParameters = new List<Parameter>
        {
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client",
                Value = ".net standard sdk"
            },
            new Parameter
            {
                Type = ParameterType.HttpHeader,
                Name = "x-groupdocs-client-version",
                Value = "19.5"
            }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public InfoApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InfoApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>DocumentInfo</returns>
        public DocumentInfo GetInfo(GetInfoRequest request)
        {
             ApiResponse<DocumentInfo> localVarResponse = GetInfoWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>ApiResponse of DocumentInfo</returns>
        public ApiResponse<DocumentInfo> GetInfoWithHttpInfo(GetInfoRequest request)
        {
            // verify the required parameter 'GetInfo.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetInfo.filePath' when calling InfoApi->GetInfo");

            var localVarPath = "./annotation/info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.filePath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "filePath", request.filePath)); // query parameter
            if (request.password != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "password", request.password)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetInfo", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<DocumentInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentInfo) _apiClient.Deserialize(localVarResponse, typeof(DocumentInfo)));
        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of DocumentInfo</returns>
        public async System.Threading.Tasks.Task<DocumentInfo> GetInfoAsync(GetInfoRequest request)
        {
             ApiResponse<DocumentInfo> localVarResponse = await GetInfoAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves basic document info - path, extension, formats, size etc 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of ApiResponse (DocumentInfo)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentInfo>> GetInfoAsyncWithHttpInfo(GetInfoRequest request)
        {
            // verify the required parameter 'GetInfo.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetInfo.filePath' when calling InfoApi->GetInfo");

            var localVarPath = "./annotation/info";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.filePath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "filePath", request.filePath)); // query parameter
            if (request.password != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "password", request.password)); // query parameter
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetInfo", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<DocumentInfo>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (DocumentInfo) _apiClient.Deserialize(localVarResponse, typeof(DocumentInfo)));
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>FormatsResult</returns>
        public FormatsResult GetSupportedFileFormats()
        {
             ApiResponse<FormatsResult> localVarResponse = GetSupportedFileFormatsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of FormatsResult</returns>
        public ApiResponse<FormatsResult> GetSupportedFileFormatsWithHttpInfo()
        {

            var localVarPath = "./annotation/formats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of FormatsResult</returns>
        public async System.Threading.Tasks.Task<FormatsResult> GetSupportedFileFormatsAsync()
        {
             ApiResponse<FormatsResult> localVarResponse = await GetSupportedFileFormatsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves supported file formats list  
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (FormatsResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FormatsResult>> GetSupportedFileFormatsAsyncWithHttpInfo()
        {

            var localVarPath = "./annotation/formats";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = _apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = _apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetSupportedFileFormats", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<FormatsResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (FormatsResult) _apiClient.Deserialize(localVarResponse, typeof(FormatsResult)));
        }

    }
}
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="GetInfoRequest.cs">
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
    using GroupDocs.Annotation.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="GroupDocs.Annotation.Cloud.Sdk.Api.InfoApi.GetInfo" /> operation.
    /// </summary>  
    public class GetInfoRequest  
    {
          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>        
          public GetInfoRequest()
          {
          }

          /// <summary>
          /// Initializes a new instance of the <see cref="GetInfoRequest"/> class.
          /// </summary>
          /// <param name="filePath">Document path in storage</param>
          /// <param name="password">Source document password</param>
          public GetInfoRequest(string filePath, string password = null)             
          {
              this.filePath = filePath;
              this.password = password;
          }

          /// <summary>
          /// Document path in storage
          /// </summary>  
          public string filePath { get; set; }
          
          /// <summary>
          /// Source document password
          /// </summary>  
          public string password { get; set; }
    }
}
