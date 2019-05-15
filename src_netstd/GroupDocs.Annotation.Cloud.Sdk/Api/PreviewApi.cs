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
    public interface IPreviewApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Removes document&#39;s pages image representations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns></returns>
        void DeletePages(DeletePagesRequest request);

        /// <summary>
        /// Removes document&#39;s pages image representations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePagesWithHttpInfo (DeletePagesRequest request);
        /// <summary>
        /// Generates image representations from documents pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>PageImages</returns>
        PageImages GetPages(GetPagesRequest request);

        /// <summary>
        /// Generates image representations from documents pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>ApiResponse of PageImages</returns>
        ApiResponse<PageImages> GetPagesWithHttpInfo (GetPagesRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Removes document&#39;s pages image representations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePagesAsync(DeletePagesRequest request);

        /// <summary>
        /// Removes document&#39;s pages image representations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePagesAsyncWithHttpInfo(DeletePagesRequest request);
        /// <summary>
        /// Generates image representations from documents pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>Task of PageImages</returns>
        System.Threading.Tasks.Task<PageImages> GetPagesAsync(GetPagesRequest request);

        /// <summary>
        /// Generates image representations from documents pages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>Task of ApiResponse (PageImages)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageImages>> GetPagesAsyncWithHttpInfo(GetPagesRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PreviewApi : IPreviewApi
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
        /// Initializes a new instance of the <see cref="PreviewApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public PreviewApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PreviewApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Removes document&#39;s pages image representations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns></returns>
        public void DeletePages(DeletePagesRequest request)
        {
             DeletePagesWithHttpInfo(request);
        }

        /// <summary>
        /// Removes document&#39;s pages image representations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePagesWithHttpInfo(DeletePagesRequest request)
        {
            // verify the required parameter 'DeletePages.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'DeletePages.filePath' when calling PreviewApi->DeletePages");

            var localVarPath = "./annotation/pages";
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
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeletePages", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Removes document&#39;s pages image representations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePagesAsync(DeletePagesRequest request)
        {
             await DeletePagesAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Removes document&#39;s pages image representations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePagesAsyncWithHttpInfo(DeletePagesRequest request)
        {
            // verify the required parameter 'DeletePages.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'DeletePages.filePath' when calling PreviewApi->DeletePages");

            var localVarPath = "./annotation/pages";
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
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("DeletePages", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Generates image representations from documents pages 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>PageImages</returns>
        public PageImages GetPages(GetPagesRequest request)
        {
             ApiResponse<PageImages> localVarResponse = GetPagesWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Generates image representations from documents pages 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>ApiResponse of PageImages</returns>
        public ApiResponse<PageImages> GetPagesWithHttpInfo(GetPagesRequest request)
        {
            // verify the required parameter 'GetPages.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetPages.filePath' when calling PreviewApi->GetPages");

            var localVarPath = "./annotation/pages";
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
            if (request.countPagesToConvert != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "countPagesToConvert", request.countPagesToConvert)); // query parameter
            if (request.pageNumber != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "pageNumber", request.pageNumber)); // query parameter
            if (request.pageNumbersToConvert != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("multi", "pageNumbersToConvert", request.pageNumbersToConvert)); // query parameter
            if (request.withoutAnnotations != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "withoutAnnotations", request.withoutAnnotations)); // query parameter
            if (request.enableCaching != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "enableCaching", request.enableCaching)); // query parameter
            if (request.cacheStoragePath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "cacheStoragePath", request.cacheStoragePath)); // query parameter
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
                Exception exception = _exceptionFactory("GetPages", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<PageImages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PageImages) _apiClient.Deserialize(localVarResponse, typeof(PageImages)));
        }

        /// <summary>
        /// Generates image representations from documents pages 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>Task of PageImages</returns>
        public async System.Threading.Tasks.Task<PageImages> GetPagesAsync(GetPagesRequest request)
        {
             ApiResponse<PageImages> localVarResponse = await GetPagesAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Generates image representations from documents pages 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="countPagesToConvert">The count pages to convert (optional, default to 0)</param>
        /// <param name="pageNumber">The start page number (optional, default to 0)</param>
        /// <param name="pageNumbersToConvert">The list of page numbers to convert (optional)</param>
        /// <param name="withoutAnnotations">If true returns specific pages without annotations (optional, default to false)</param>
        /// <param name="enableCaching">Indicates whether to use previously cached document or not (optional, default to false)</param>
        /// <param name="cacheStoragePath">The cache storage path (optional)</param>
        /// <param name="password">Source document opening password (optional)</param>
        /// <returns>Task of ApiResponse (PageImages)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageImages>> GetPagesAsyncWithHttpInfo(GetPagesRequest request)
        {
            // verify the required parameter 'GetPages.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetPages.filePath' when calling PreviewApi->GetPages");

            var localVarPath = "./annotation/pages";
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
            if (request.countPagesToConvert != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "countPagesToConvert", request.countPagesToConvert)); // query parameter
            if (request.pageNumber != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "pageNumber", request.pageNumber)); // query parameter
            if (request.pageNumbersToConvert != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("multi", "pageNumbersToConvert", request.pageNumbersToConvert)); // query parameter
            if (request.withoutAnnotations != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "withoutAnnotations", request.withoutAnnotations)); // query parameter
            if (request.enableCaching != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "enableCaching", request.enableCaching)); // query parameter
            if (request.cacheStoragePath != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "cacheStoragePath", request.cacheStoragePath)); // query parameter
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
                Exception exception = _exceptionFactory("GetPages", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<PageImages>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (PageImages) _apiClient.Deserialize(localVarResponse, typeof(PageImages)));
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
