# mynhs.sdk.Api.AppointmentsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdAppointmentsGet**](AppointmentsApi.md#mynhsuseridappointmentsget) | **GET** /mynhs/{userId}/appointments | 

<a name="mynhsuseridappointmentsget"></a>
# **MynhsUserIdAppointmentsGet**
> NhsProfile MynhsUserIdAppointmentsGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdAppointmentsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AppointmentsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdAppointmentsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AppointmentsApi.MynhsUserIdAppointmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
