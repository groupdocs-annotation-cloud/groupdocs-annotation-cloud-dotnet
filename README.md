# GroupDocs.Annotation Cloud SDK for .NET
This repository contains GroupDocs.Annotation Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Annotation Cloud REST APIs in your .NET applications.

## How to use the SDK?
The complete source code is available in this repository folder, you can either directly use it in your project via NuGet package manager. For more details, please visit our [documentation website](https://docs.groupdocs.cloud/display/annotationcloud/Available+SDKs#AvailableSDKs-.NET).

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json)
- [StyleCop.MSBuild](https://www.nuget.org/packages/StyleCop.MSBuild)

NOTE: The DLLs included in the package may not be up to date. We recommended using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package Newtonsoft.Json
Install-Package StyleCop.MSBuild
``` 

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Annotation.Cloud.Sdk.Api;
using GroupDocs.Annotation.Cloud.Sdk.Client;
using GroupDocs.Annotation.Cloud.Sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
        	//TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance = new AnnotationApi();
            var name = name_example;  // string | The document name.
            var folder = folder_example;  // string | The folder name. (optional) 
            var password = password_example;  // string |  (optional) 

            try
            {
                // Removes annotations from document.
                System.IO.Stream result = apiInstance.DeleteCleanDocument(name, folder, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AnnotationApi.DeleteCleanDocument: " + e.Message );
            }

        }
    }
}
```

## Licensing
All GroupDocs.Annotation for Cloud SDKs are licensed under [MIT License](LICENSE).

## Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/annotation/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/annotationcloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/annotation)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-annotation-cloud-product-family/)

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.groupdocs.cloud/c/annotation).