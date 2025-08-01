// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ApiInvoker.cs">
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

namespace GroupDocs.Annotation.Cloud.Sdk.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text;

    internal class ApiInvoker
    {
        private const string GroupDocsClientHeaderName = "x-groupdocs-client";
        private const string GroupDocsClientVersionHeaderName = "x-groupdocs-client-version";
        private readonly Dictionary<string, string> defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> requestHandlers;
        private readonly int _timeout;

        public ApiInvoker(List<IRequestHandler> requestHandlers, int timeout)
        {
            var sdkVersion = this.GetType().Assembly.GetName().Version;
            this.AddDefaultHeader(GroupDocsClientHeaderName, ".net sdk");
            this.AddDefaultHeader(GroupDocsClientVersionHeaderName, string.Format("{0}.{1}", sdkVersion.Major, sdkVersion.Minor));
            this.requestHandlers = requestHandlers;
            this._timeout = timeout;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType) (0xc0 | 0x300 | 0xc00);
        }

        public string InvokeApi(
            string path,
            string method,
            string body = null,
            Dictionary<string, string> headerParams = null,
            Dictionary<string, object> formParams = null,
            string contentType = "application/json")
        {
            return this.InvokeInternal(path, method, false, body, headerParams, formParams, contentType) as string;
        }

        public Stream InvokeBinaryApi(
            string path,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams,
            string contentType = "application/json")
        {
            return (Stream)this.InvokeInternal(path, method, true, body, headerParams, formParams, contentType);
        }

        public FileInfo ToFileInfo(Stream stream, string paramName)
        {
            string contentType = paramName.Equals("File", StringComparison.InvariantCultureIgnoreCase)
                ? "application/octet-stream"
                : "application/json";

            return new FileInfo
            {
                Name = paramName,
                MimeType = contentType,
                FileContent = StreamHelper.ReadAsBytes(stream)
            };
        }

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            Stream formDataStream = new MemoryStream();
            bool needsClrf = false;

            foreach (var param in postParameters)
            {
                // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                // Skip it on the first parameter, add it to subsequent parameters.
                if (needsClrf)
                {
                    formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
                }

                needsClrf = true;

                if (param.Value is FileInfo)
                {
                    var fileInfo = (FileInfo)param.Value;
                    string postData =
                        string.Format(
                            "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n",
                            boundary,
                            param.Key,
                            fileInfo.MimeType);
                    formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                    // Write the file data directly to the Stream, rather than serializing it to a string.
                    formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                }
                else
                {
                    var stringDaa = SerializationHelper.Serialize(param.Value);
                    string postData =
                        string.Format(
                            "--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
                            boundary,
                            param.Key,
                            stringDaa);
                    formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));
                }
            }

            // Add the end of the request.  Start with a newline
            string footer = "\r\n--" + boundary + "--\r\n";
            formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            byte[] formData = new byte[formDataStream.Length];
            formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!this.defaultHeaderMap.ContainsKey(key))
            {
                this.defaultHeaderMap.Add(key, value);
            }
        }

        private object InvokeInternal(
            string path,
            string method,
            bool binaryResponse,
            string body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams,
            string contentType)
        {
            if (formParams == null)
            {
                formParams = new Dictionary<string, object>();
            }

            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }

            this.requestHandlers.ForEach(p => path = p.ProcessUrl(path));

            WebRequest request;
            try
            {
                request = this.PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return this.ReadResponse(request, binaryResponse);
            }
            catch (NeedRepeatRequestException)
            {
                request = this.PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return this.ReadResponse(request, binaryResponse);
            }
        }

        private WebRequest PrepareRequest(string path, string method, Dictionary<string, object> formParams, Dictionary<string, string> headerParams, string body, string contentType)
        {
            var client = WebRequest.Create(path);
            client.Method = method;
            client.Timeout = _timeout;

            byte[] formData = null;
            if (formParams.Count > 0)
            {
                string formDataBoundary = "GroupDocsAnnotationForCloud_NETSDKFormBoundary";
                client.ContentType = "multipart/form-data; boundary=" + formDataBoundary;

                if (formParams.Count > 1)
                {
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }
                else
                {
                    formData = GetMultipartFormData(formParams, formDataBoundary);
                }

                client.ContentLength = formData.Length;
            }
            else
            {
                client.ContentType = contentType;
            }

            foreach (var headerParamsItem in headerParams)
            {
                client.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (var defaultHeaderMapItem in this.defaultHeaderMap)
            {
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                {
                    client.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
                }
            }

            MemoryStream streamToSend = null;
            try
            {
                switch (method)
                {
                    case "GET":
                        break;
                    case "POST":
                    case "PUT":
                    case "DELETE":
                        streamToSend = new MemoryStream();

                        if (formData != null)
                        {
                            streamToSend.Write(formData, 0, formData.Length);
                        }

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(streamToSend);
                            requestWriter.Write(body);
                            requestWriter.Flush();
                        }

                        break;
                    default:
                        throw new ApiException(500, "unknown method type " + method);
                }

                this.requestHandlers.ForEach(p => p.BeforeSend(client, streamToSend));

                if (streamToSend != null)
                {
                    using (Stream requestStream = client.GetRequestStream())
                    {
                        StreamHelper.CopyTo(streamToSend, requestStream);
                    }
                }
            }
            finally
            {
                if (streamToSend != null)
                {
                    streamToSend.Dispose();
                }
            }

            return client;
        }

        private object ReadResponse(WebRequest client, bool binaryResponse)
        {
            var webResponse = (HttpWebResponse)this.GetResponse(client);
            var resultStream = new MemoryStream();
            try
            {
                StreamHelper.CopyTo(webResponse.GetResponseStream(), resultStream);

                this.requestHandlers.ForEach(p => p.ProcessResponse(webResponse, resultStream));

                resultStream.Position = 0;
                if (binaryResponse)
                {
                    return resultStream;
                }

                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    resultStream.Dispose();
                    return responseData;
                }
            }
            catch (Exception)
            {
                resultStream.Dispose();
                throw;
            }
            finally
            {
                webResponse.Close();
            }
        }

        private WebResponse GetResponse(WebRequest request)
        {
            try
            {
                return request.GetResponse();
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    return wex.Response;
                }

                throw;
            }
        }
    }
}
