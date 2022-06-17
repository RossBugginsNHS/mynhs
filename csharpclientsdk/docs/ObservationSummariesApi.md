# IO.Swagger.Api.ObservationSummariesApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGet**](ObservationSummariesApi.md#mynhsmyobservationssummariesbloodpressurequerytypepastdaysget) | **GET** /mynhs/my/observations/summaries/bloodpressure/{queryType}/{pastDays} | 
[**MynhsMyObservationsSummariesGet**](ObservationSummariesApi.md#mynhsmyobservationssummariesget) | **GET** /mynhs/my/observations/summaries | 

<a name="mynhsmyobservationssummariesbloodpressurequerytypepastdaysget"></a>
# **MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGet**
> NhsProfile MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGet (string queryType, decimal? pastDays)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ObservationSummariesApi();
            var queryType = queryType_example;  // string | 
            var pastDays = 1.2;  // decimal? | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGet(queryType, pastDays);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationSummariesApi.MynhsMyObservationsSummariesBloodpressureQueryTypePastDaysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryType** | **string**|  | 
 **pastDays** | **decimal?**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmyobservationssummariesget"></a>
# **MynhsMyObservationsSummariesGet**
> NhsProfile MynhsMyObservationsSummariesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsSummariesGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationSummariesApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSummariesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationSummariesApi.MynhsMyObservationsSummariesGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
