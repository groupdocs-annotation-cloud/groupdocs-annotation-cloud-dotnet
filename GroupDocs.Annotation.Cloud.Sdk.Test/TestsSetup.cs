using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using NUnit.Framework;
using Configuration = GroupDocs.Annotation.Cloud.Sdk.Api.Configuration;

namespace GroupDocs.Annotation.Cloud.Sdk.Test
{
    public class TestsSetup
    {
        private readonly string _appSid = ConfigurationManager.AppSettings["AppSID"];
        private readonly string _appKey = ConfigurationManager.AppSettings["AppKey"];
        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];

        protected AnnotationApi _annotationApi;
        protected ImageInfoApi _imageInfoApi;
        protected ImagePagesApi _imagePagesApi;
        protected PdfFileApi _pdfFileApi;
        private StorageApi _storageApi;

        public TestsSetup()
        {
            var config = new Configuration
            {
                AuthType = AuthType.OAuth2,
                AppSid = _appSid,
                AppKey = _appKey,
                ApiBaseUrl = _apiBaseUrl
            };
            _annotationApi = new AnnotationApi(config);
            _imageInfoApi = new ImageInfoApi(config);
            _imagePagesApi = new ImagePagesApi(config);
            _pdfFileApi = new PdfFileApi(config);
            _storageApi = new StorageApi(config);
        }

        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            //UploadTestFiles();
        }

        private void UploadTestFiles()
        {
            var path = GetTestDataPath();

            var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.IsExist(relativeDirPath);
                if (!response.FileExist.IsExist)
                    _storageApi.CreateFolder(relativeDirPath);
            }

            var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

                var response = _storageApi.IsExist(relativeFilePath);
                if (!response.FileExist.IsExist)
                {
                    var fileName = Path.GetFileName(file);
                    var relativeDirPath = relativeFilePath.Replace(fileName, string.Empty).Trim(Path.DirectorySeparatorChar);
                    var bytes = File.ReadAllBytes(file);

                    _storageApi.CreateFile(fileName, relativeDirPath, bytes);
                }
            }
        }

        private string GetTestDataPath()
        {
            var uri = new Uri(Assembly.GetExecutingAssembly().CodeBase);
            var workingDir = Path.GetDirectoryName(uri.LocalPath);
            if (workingDir == null)
                workingDir = Directory.GetCurrentDirectory();

            var baseDir = Path.Combine(workingDir, "..\\..\\Resources", "TestData");

            return Path.GetFullPath(baseDir);
        }
        [TearDown]
        public void AfterEachTest()
        {
            RemoveTempFiles();
        }

        private void RemoveTempFiles()
        {
            _storageApi.DeleteFolder("cache");
            _storageApi.DeleteFolder("tests");
        }
    }
}