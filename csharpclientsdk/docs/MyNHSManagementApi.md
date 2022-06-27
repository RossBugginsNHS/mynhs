# mynhs.sdk.Api.MyNHSManagementApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HelloworldHiGet**](MyNHSManagementApi.md#helloworldhiget) | **GET** /helloworld/hi | 
[**MynhsmanagementTenantsGet**](MyNHSManagementApi.md#mynhsmanagementtenantsget) | **GET** /mynhsmanagement/tenants | 

<a name="helloworldhiget"></a>
# **HelloworldHiGet**
> NhsProfile HelloworldHiGet ()



Test

### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class HelloworldHiGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("X-API-KEY", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-API-KEY", "Bearer");

            var apiInstance = new MyNHSManagementApi();

            try
            {
                NhsProfile result = apiInstance.HelloworldHiGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyNHSManagementApi.HelloworldHiGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmanagementtenantsget"></a>
# **MynhsmanagementTenantsGet**
> NhsProfile MynhsmanagementTenantsGet ()



Gets a list of all tenancies for the current user. Required OAuth Scopes: [tenants.read]

### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsmanagementTenantsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyNHSManagementApi();

            try
            {
                NhsProfile result = apiInstance.MynhsmanagementTenantsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyNHSManagementApi.MynhsmanagementTenantsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
