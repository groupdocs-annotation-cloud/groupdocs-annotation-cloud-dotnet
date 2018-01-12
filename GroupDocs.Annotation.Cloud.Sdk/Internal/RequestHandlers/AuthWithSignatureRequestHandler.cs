using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using GroupDocs.Annotation.Cloud.Sdk.Api;
namespace GroupDocs.Annotation.Cloud.Sdk.Internal.RequestHandlers
{
    internal class AuthWithSignatureRequestHandler : IRequestHandler
    {
        private readonly Configuration configuration;

        public AuthWithSignatureRequestHandler(Configuration configuration)
        {
            this.configuration = configuration;
        }

        public string ProcessUrl(string url)
        {
            if (this.configuration.AuthType != AuthType.RequestSignature)
            {
                return url;
            }

            url = UrlHelper.AddQueryParameterToUrl(url, "appsid", this.configuration.AppSid);
            url = this.Sign(url);

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        private string Sign(string url)
        {
            var signature = this.GetSignature(url, this.configuration.AppKey);
            var signedUrl = string.Format("{0}&signature={1}", url, signature);

            return signedUrl;
        }

        private string GetSignature(string url, string key)
        {
            var encoding = new ASCIIEncoding();

            var usablePrivateKey = key.Replace("-", "+").Replace("_", "/");
            var privateKeyBytes = Convert.FromBase64String(usablePrivateKey);

            var uri = new Uri(url);
            var encodedPathAndQueryBytes = encoding.GetBytes(uri.LocalPath + uri.Query);

            var algorithm = new HMACSHA1(privateKeyBytes);
            var hash = algorithm.ComputeHash(encodedPathAndQueryBytes);

            var result = Convert.ToBase64String(hash).Replace("+", "-").Replace("/", "_");
            return result;
        }
    }
}