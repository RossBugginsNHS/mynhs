# mynhs.sdk.Api.ObservationsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdObservationsObservationTypeGet**](ObservationsApi.md#mynhsuseridobservationsobservationtypeget) | **GET** /mynhs/{userId}/observations/{observationType} | 
[**MynhsUserIdObservationsSummariesGet**](ObservationsApi.md#mynhsuseridobservationssummariesget) | **GET** /mynhs/{userId}/observations/summaries | 
[**MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGet**](ObservationsApi.md#mynhsuseridobservationssummariesobservationtypequerytypepastdaysget) | **GET** /mynhs/{userId}/observations/summaries/{observationType}/{queryType}/{pastDays} | 

<a name="mynhsuseridobservationsobservationtypeget"></a>
# **MynhsUserIdObservationsObservationTypeGet**
> NhsProfile MynhsUserIdObservationsObservationTypeGet (string userId, string observationType, int? skip = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsObservationTypeGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();
            var userId = userId_example;  // string | The User Id to access
            var observationType = observationType_example;  // string | 
            var skip = 56;  // int? | The number of items to skip before starting to collect the result set. (optional) 
            var limit = 56;  // int? | The numbers of items to return. (optional)  (default to 20)

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsObservationTypeGet(userId, observationType, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsUserIdObservationsObservationTypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **observationType** | **string**|  | 
 **skip** | **int?**| The number of items to skip before starting to collect the result set. | [optional] 
 **limit** | **int?**| The numbers of items to return. | [optional] [default to 20]

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridobservationssummariesget"></a>
# **MynhsUserIdObservationsSummariesGet**
> NhsProfile MynhsUserIdObservationsSummariesGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSummariesGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSummariesGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsUserIdObservationsSummariesGet: " + e.Message );
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
<a name="mynhsuseridobservationssummariesobservationtypequerytypepastdaysget"></a>
# **MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGet**
> NhsProfile MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGet (string userId, string observationType, string queryType, decimal? pastDays)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObservationsApi();
            var userId = userId_example;  // string | The User Id to access
            var observationType = observationType_example;  // string | 
            var queryType = queryType_example;  // string | 
            var pastDays = 1.2;  // decimal? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGet(userId, observationType, queryType, pastDays);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsUserIdObservationsSummariesObservationTypeQueryTypePastDaysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **observationType** | **string**|  | 
 **queryType** | **string**|  | 
 **pastDays** | **decimal?**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
