# mynhs.sdk.Api.AuditsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdAuditsGet**](AuditsApi.md#mynhsuseridauditsget) | **GET** /mynhs/{userId}/audits | 

<a name="mynhsuseridauditsget"></a>
# **MynhsUserIdAuditsGet**
> NhsProfile MynhsUserIdAuditsGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdAuditsGetExample
    {
        public void main()
        {
            var apiInstance = new AuditsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdAuditsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditsApi.MynhsUserIdAuditsGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
