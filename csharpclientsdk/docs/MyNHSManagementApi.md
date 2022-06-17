# mynhs.sdk.Api.MyNHSManagementApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsmanagementTenantsGet**](MyNHSManagementApi.md#mynhsmanagementtenantsget) | **GET** /mynhsmanagement/tenants | 

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
            // Configure OAuth2 access token for authorization: OAuth2
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

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
