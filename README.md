![](https://img.shields.io/badge/api-v2.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.Annotation-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.Annotation-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-annotation-cloud/groupdocs-annotation-cloud-dotnet)](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-dotnet/blob/master/LICENSE) 

# .NET SDK for Document Annotation via REST API

The .NET Cloud SDK enhances your C#, ASP.NET, & other .NET-based apps to [Annotate Documents in the Cloud](https://products.groupdocs.cloud/annotation/net).

## Annotate Documents & Images in the Cloud

- Import document annotations.
- Add or remove annotations.
- Export annotated document back to its original format.
- Preview document pages as images.
- Fetch document information, such as, page count & file size.

Check out the [Developer's Guide](https://docs.groupdocs.cloud/annotation/developer-guide/) to know more about GroupDocs.Annotation REST API.

## Microsoft Office Formats

**Microsoft Word:** DOC, DOCM, DOCX, DOT, DOTM, DOTX, RTF\
**Microsoft Excel:** XLS, XLSX\
**Microsoft PowerPoint:** PPT, PPTX, PPSX\
**Microsoft Visio:** VSSX, VSS, VSSM, VDX, VSD, VSDX, VSDM, VSTM, VSX, VTX\
**Microsoft Outlook:** EML, EMLX, MSG

## Other Document Formats

**Portable:** PDF\
**OpenDocument:** ODT, OTT, ODP, OTP\
**Images:** BMP, PNG, JPG, JPEG, TIFF, TIF, GIF\
**Web:** MHTML\
**Others:** TXT

## Get Started with GroupDocs.Annotation Cloud SDK for .NET

You do not need to install anything to get started with GroupDocs.Annotation Cloud SDK for .NET. Just create an account at [GroupDocs for Cloud](https://dashboard.groupdocs.cloud/) and get your application information.

Next, execute `Install-Package GroupDocs.Annotation-Cloud` from the Package Manager Console in Visual Studio to fetch & reference SDK assembly in your project. Please execute `Update-Package GroupDocs.Annotation-Cloud` to get the latest version of the SDK if you already have it.

### Dependencies

+[Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)

## Get Supported File Formats for Annotation

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Annotation.Cloud.Sdk.Api;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var appSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX";
            var appKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

            var api = new InfoApi(appSid, appKey);

            try
            {
                // Get supported file formats
                var response = api.GetSupportedFileFormats();

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Something went wrong: " + e.Message);
            }
        }
    }
}
```

## GroupDocs.Annotation Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js |
|---|---|---|---|---|---|
| [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-dotnet) | [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-java) | [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-php) | [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-python) | [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-ruby)  | [GitHub](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-node) |
| [NuGet](https://www.nuget.org/packages/GroupDocs.Annotation-Cloud/) | [Maven](https://repository.groupdocs.cloud/webapp/#/artifacts/browse/tree/General/repo/com/groupdocs/groupdocs-annotation-cloud) | [Composer](https://packagist.org/packages/groupdocscloud/groupdocs-annotation-cloud) | [PIP](https://pypi.org/project/groupdocs-annotation-cloud/) | [GEM](https://rubygems.org/gems/groupdocs_annotation_cloud)  | [NPM](https://www.npmjs.com/package/groupdocs-annotation-cloud) | 

[Home](https://www.groupdocs.cloud/) | [Product Page](https://products.groupdocs.cloud/annotation/net) | [Documentation](https://docs.groupdocs.cloud/annotation/) | [Live Demo](https://products.groupdocs.app/annotation/total) | [API Reference](https://apireference.groupdocs.cloud/annotation/) | [Code Samples](https://github.com/groupdocs-annotation-cloud/groupdocs-annotation-cloud-dotnet-samples) | [Blog](https://blog.groupdocs.cloud/category/annotation/) | [Free Support](https://forum.groupdocs.cloud/c/annotation) | [Free Trial](https://dashboard.groupdocs.cloud)
