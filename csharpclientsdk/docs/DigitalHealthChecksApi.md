# mynhs.sdk.Api.DigitalHealthChecksApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdDigitalhealthchecksHealthCheckIdGet**](DigitalHealthChecksApi.md#mynhsuseriddigitalhealthcheckshealthcheckidget) | **GET** /mynhs/{userId}/digitalhealthchecks/{healthCheckId} | 
[**MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGet**](DigitalHealthChecksApi.md#mynhsuseriddigitalhealthcheckshealthcheckidhealthchecktypeget) | **GET** /mynhs/{userId}/digitalhealthchecks/{healthCheckId}/{healthCheckType} | 

<a name="mynhsuseriddigitalhealthcheckshealthcheckidget"></a>
# **MynhsUserIdDigitalhealthchecksHealthCheckIdGet**
> NhsProfile MynhsUserIdDigitalhealthchecksHealthCheckIdGet (string userId, Guid? healthCheckId, int? skip = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksHealthCheckIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var userId = userId_example;  // string | The User Id to access
            var healthCheckId = new Guid?(); // Guid? | 
            var skip = 56;  // int? | The number of items to skip before starting to collect the result set. (optional) 
            var limit = 56;  // int? | The numbers of items to return. (optional)  (default to 20)

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksHealthCheckIdGet(userId, healthCheckId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsUserIdDigitalhealthchecksHealthCheckIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **healthCheckId** | [**Guid?**](Guid?.md)|  | 
 **skip** | **int?**| The number of items to skip before starting to collect the result set. | [optional] 
 **limit** | **int?**| The numbers of items to return. | [optional] [default to 20]

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseriddigitalhealthcheckshealthcheckidhealthchecktypeget"></a>
# **MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGet**
> NhsProfile MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGet (string userId, Guid? healthCheckId, string healthCheckType, int? skip = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var userId = userId_example;  // string | The User Id to access
            var healthCheckId = new Guid?(); // Guid? | 
            var healthCheckType = healthCheckType_example;  // string | 
            var skip = 56;  // int? | The number of items to skip before starting to collect the result set. (optional) 
            var limit = 56;  // int? | The numbers of items to return. (optional)  (default to 20)

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGet(userId, healthCheckId, healthCheckType, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsUserIdDigitalhealthchecksHealthCheckIdHealthCheckTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **healthCheckId** | [**Guid?**](Guid?.md)|  | 
 **healthCheckType** | **string**|  | 
 **skip** | **int?**| The number of items to skip before starting to collect the result set. | [optional] 
 **limit** | **int?**| The numbers of items to return. | [optional] [default to 20]

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
