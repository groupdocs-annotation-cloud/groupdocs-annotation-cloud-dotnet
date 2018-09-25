# GroupDocs.Annotation for Cloud SDKs
This folder contains SDKs for [GroupDocs.Annotation for Cloud](https://products.groupdocs.cloud/annotation/cloud) for various platforms.

# Currently Available SDKs

Directory | Description
--------- | -----------
[.NET SDK](SDKs/NET) | GroupDocs.Annotation for Cloud .NET SDK

To use these SDKs, you will need App SID and App Key which can be looked up at [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) (free registration in GroupDocs Cloud is required for this).

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

# Licensing
All GroupDocs.Annotation for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/annotation)
+ [**Documentation**](https://docs.groupdocs.cloud/display/annotationcloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/annotation)
+ [**Blog**](https://blog.groupdocs.cloud/category/annotation)