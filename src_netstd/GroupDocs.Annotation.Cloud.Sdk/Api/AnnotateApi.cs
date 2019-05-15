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
    public interface IAnnotateApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Removes annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns></returns>
        void DeleteAnnotations(DeleteAnnotationsRequest request);

        /// <summary>
        /// Removes annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAnnotationsWithHttpInfo (DeleteAnnotationsRequest request);
        /// <summary>
        /// Retrieves document with annotations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetExport(GetExportRequest request);

        /// <summary>
        /// Retrieves document with annotations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetExportWithHttpInfo (GetExportRequest request);
        /// <summary>
        /// Extracts annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>List&lt;AnnotationInfo&gt;</returns>
        List<AnnotationInfo> GetImport(GetImportRequest request);

        /// <summary>
        /// Extracts annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of List&lt;AnnotationInfo&gt;</returns>
        ApiResponse<List<AnnotationInfo>> GetImportWithHttpInfo (GetImportRequest request);
        /// <summary>
        /// Retrieves PDF version of document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetPdf(GetPdfRequest request);

        /// <summary>
        /// Retrieves PDF version of document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetPdfWithHttpInfo (GetPdfRequest request);
        /// <summary>
        /// Adds annotations to document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns></returns>
        void PostAnnotations(PostAnnotationsRequest request);

        /// <summary>
        /// Adds annotations to document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PostAnnotationsWithHttpInfo (PostAnnotationsRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Removes annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAnnotationsAsync(DeleteAnnotationsRequest request);

        /// <summary>
        /// Removes annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAnnotationsAsyncWithHttpInfo(DeleteAnnotationsRequest request);
        /// <summary>
        /// Retrieves document with annotations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetExportAsync(GetExportRequest request);

        /// <summary>
        /// Retrieves document with annotations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetExportAsyncWithHttpInfo(GetExportRequest request);
        /// <summary>
        /// Extracts annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of List&lt;AnnotationInfo&gt;</returns>
        System.Threading.Tasks.Task<List<AnnotationInfo>> GetImportAsync(GetImportRequest request);

        /// <summary>
        /// Extracts annotations from document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse (List&lt;AnnotationInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<AnnotationInfo>>> GetImportAsyncWithHttpInfo(GetImportRequest request);
        /// <summary>
        /// Retrieves PDF version of document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetPdfAsync(GetPdfRequest request);

        /// <summary>
        /// Retrieves PDF version of document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPdfAsyncWithHttpInfo(GetPdfRequest request);
        /// <summary>
        /// Adds annotations to document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PostAnnotationsAsync(PostAnnotationsRequest request);

        /// <summary>
        /// Adds annotations to document
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PostAnnotationsAsyncWithHttpInfo(PostAnnotationsRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnnotateApi : IAnnotateApi
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
        /// Initializes a new instance of the <see cref="AnnotateApi"/> class.
        /// </summary>
        /// <param name="appSid">Application identifier (App SID)</param>
        /// <param name="appKey">Application private key (App Key)</param>
        public AnnotateApi(string appSid, string appKey)
            : this(new Configuration(appSid, appKey))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnnotateApi(Configuration configuration)
        {
            this._configuration = configuration;
            this._apiClient = new ApiClient(configuration, _defaultParameters);
            this._authorization = new Auth(configuration, _defaultParameters);
        }

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns></returns>
        public void DeleteAnnotations(DeleteAnnotationsRequest request)
        {
             DeleteAnnotationsWithHttpInfo(request);
        }

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAnnotationsWithHttpInfo(DeleteAnnotationsRequest request)
        {
            // verify the required parameter 'DeleteAnnotations.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'DeleteAnnotations.filePath' when calling AnnotateApi->DeleteAnnotations");

            var localVarPath = "./annotation";
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
                Exception exception = _exceptionFactory("DeleteAnnotations", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAnnotationsAsync(DeleteAnnotationsRequest request)
        {
             await DeleteAnnotationsAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Removes annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAnnotationsAsyncWithHttpInfo(DeleteAnnotationsRequest request)
        {
            // verify the required parameter 'DeleteAnnotations.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'DeleteAnnotations.filePath' when calling AnnotateApi->DeleteAnnotations");

            var localVarPath = "./annotation";
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
                Exception exception = _exceptionFactory("DeleteAnnotations", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Retrieves document with annotations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetExport(GetExportRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetExportWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves document with annotations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> GetExportWithHttpInfo(GetExportRequest request)
        {
            // verify the required parameter 'GetExport.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetExport.filePath' when calling AnnotateApi->GetExport");

            var localVarPath = "./annotation/result";
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
            if (request.annotationTypes != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "annotationTypes", request.annotationTypes)); // query parameter
            if (request.annotatedPages != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "annotatedPages", request.annotatedPages)); // query parameter
            if (request.firstPage != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "firstPage", request.firstPage)); // query parameter
            if (request.lastPage != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "lastPage", request.lastPage)); // query parameter
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
                Exception exception = _exceptionFactory("GetExport", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Retrieves document with annotations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetExportAsync(GetExportRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetExportAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves document with annotations 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotationTypes">Annotation types that will be exported. All annotation types will be exported if not specified (optional)</param>
        /// <param name="annotatedPages">Indicates whether to export only annotated pages (optional, default to false)</param>
        /// <param name="firstPage">Determines number of first exported page (optional, default to -1)</param>
        /// <param name="lastPage">Determines number of last exported page (optional, default to -1)</param>
        /// <param name="password">Source document password (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetExportAsyncWithHttpInfo(GetExportRequest request)
        {
            // verify the required parameter 'GetExport.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetExport.filePath' when calling AnnotateApi->GetExport");

            var localVarPath = "./annotation/result";
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
            if (request.annotationTypes != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "annotationTypes", request.annotationTypes)); // query parameter
            if (request.annotatedPages != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "annotatedPages", request.annotatedPages)); // query parameter
            if (request.firstPage != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "firstPage", request.firstPage)); // query parameter
            if (request.lastPage != null) localVarQueryParams.AddRange(_apiClient.ParameterToKeyValuePairs("", "lastPage", request.lastPage)); // query parameter
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
                Exception exception = _exceptionFactory("GetExport", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>List&lt;AnnotationInfo&gt;</returns>
        public List<AnnotationInfo> GetImport(GetImportRequest request)
        {
             ApiResponse<List<AnnotationInfo>> localVarResponse = GetImportWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>ApiResponse of List&lt;AnnotationInfo&gt;</returns>
        public ApiResponse<List<AnnotationInfo>> GetImportWithHttpInfo(GetImportRequest request)
        {
            // verify the required parameter 'GetImport.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetImport.filePath' when calling AnnotateApi->GetImport");

            var localVarPath = "./annotation";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetImport", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<List<AnnotationInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<AnnotationInfo>) _apiClient.Deserialize(localVarResponse, typeof(List<AnnotationInfo>)));
        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of List&lt;AnnotationInfo&gt;</returns>
        public async System.Threading.Tasks.Task<List<AnnotationInfo>> GetImportAsync(GetImportRequest request)
        {
             ApiResponse<List<AnnotationInfo>> localVarResponse = await GetImportAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Extracts annotations from document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <returns>Task of ApiResponse (List&lt;AnnotationInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<AnnotationInfo>>> GetImportAsyncWithHttpInfo(GetImportRequest request)
        {
            // verify the required parameter 'GetImport.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetImport.filePath' when calling AnnotateApi->GetImport");

            var localVarPath = "./annotation";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetImport", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<List<AnnotationInfo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (List<AnnotationInfo>) _apiClient.Deserialize(localVarResponse, typeof(List<AnnotationInfo>)));
        }

        /// <summary>
        /// Retrieves PDF version of document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetPdf(GetPdfRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetPdfWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves PDF version of document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse<System.IO.Stream> GetPdfWithHttpInfo(GetPdfRequest request)
        {
            // verify the required parameter 'GetPdf.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetPdf.filePath' when calling AnnotateApi->GetPdf");

            var localVarPath = "./annotation/pdf";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetPdf", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Retrieves PDF version of document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetPdfAsync(GetPdfRequest request)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetPdfAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves PDF version of document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Path to document in storage</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPdfAsyncWithHttpInfo(GetPdfRequest request)
        {
            // verify the required parameter 'GetPdf.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'GetPdf.filePath' when calling AnnotateApi->GetPdf");

            var localVarPath = "./annotation/pdf";
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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("GetPdf", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) _apiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Adds annotations to document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns></returns>
        public void PostAnnotations(PostAnnotationsRequest request)
        {
             PostAnnotationsWithHttpInfo(request);
        }

        /// <summary>
        /// Adds annotations to document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PostAnnotationsWithHttpInfo(PostAnnotationsRequest request)
        {
            // verify the required parameter 'PostAnnotations.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'PostAnnotations.filePath' when calling AnnotateApi->PostAnnotations");
            // verify the required parameter 'PostAnnotations.annotations' is set
            if (request.annotations == null)
                throw new ApiException(400, "Missing required parameter 'PostAnnotations.annotations' when calling AnnotateApi->PostAnnotations");

            var localVarPath = "./annotation";
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
            if (request.annotations != null && request.annotations.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.annotations); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.annotations; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) _apiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PostAnnotations", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Adds annotations to document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PostAnnotationsAsync(PostAnnotationsRequest request)
        {
             await PostAnnotationsAsyncWithHttpInfo(request);

        }

        /// <summary>
        /// Adds annotations to document 
        /// </summary>
        /// <exception cref="GroupDocs.Annotation.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filePath">Document path in storage</param>
        /// <param name="annotations">Array of annotation descriptions</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PostAnnotationsAsyncWithHttpInfo(PostAnnotationsRequest request)
        {
            // verify the required parameter 'PostAnnotations.filePath' is set
            if (request.filePath == null)
                throw new ApiException(400, "Missing required parameter 'PostAnnotations.filePath' when calling AnnotateApi->PostAnnotations");
            // verify the required parameter 'PostAnnotations.annotations' is set
            if (request.annotations == null)
                throw new ApiException(400, "Missing required parameter 'PostAnnotations.annotations' when calling AnnotateApi->PostAnnotations");

            var localVarPath = "./annotation";
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
            if (request.annotations != null && request.annotations.GetType() != typeof(byte[]))
            {
                localVarPostBody = _apiClient.Serialize(request.annotations); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request.annotations; // byte array
            }
            // apply Authorization to header or query parameters
            _authorization.ApplyToParams(localVarQueryParams, localVarHeaderParams);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await _apiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (_exceptionFactory != null)
            {
                Exception exception = _exceptionFactory("PostAnnotations", localVarResponse);
                if (exception != null) 
                    throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
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
