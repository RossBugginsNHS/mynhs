# mynhs.sdk.Api.DigitalHealthToolsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsToolsBloodpressurePost**](DigitalHealthToolsApi.md#mynhstoolsbloodpressurepost) | **POST** /mynhs/tools/bloodpressure | 
[**MynhsToolsHeartagePost**](DigitalHealthToolsApi.md#mynhstoolsheartagepost) | **POST** /mynhs/tools/heartage | 
[**PostHealthCheck**](DigitalHealthToolsApi.md#posthealthcheck) | **POST** /mynhs/tools/healthcheck | Run a health check on provided data

<a name="mynhstoolsbloodpressurepost"></a>
# **MynhsToolsBloodpressurePost**
> BloodPressureResult MynhsToolsBloodpressurePost (BloodPressure body)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsToolsBloodpressurePostExample
    {
        public void main()
        {
            var apiInstance = new DigitalHealthToolsApi();
            var body = new BloodPressure(); // BloodPressure | Returns an analysis of the given blood pressure reading.

            try
            {
                BloodPressureResult result = apiInstance.MynhsToolsBloodpressurePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthToolsApi.MynhsToolsBloodpressurePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BloodPressure**](BloodPressure.md)| Returns an analysis of the given blood pressure reading. | 

### Return type

[**BloodPressureResult**](BloodPressureResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhstoolsheartagepost"></a>
# **MynhsToolsHeartagePost**
> DigitalHealthCheckResult MynhsToolsHeartagePost (DigitalHealthCheckRequest body)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsToolsHeartagePostExample
    {
        public void main()
        {
            var apiInstance = new DigitalHealthToolsApi();
            var body = new DigitalHealthCheckRequest(); // DigitalHealthCheckRequest | Optional description in *Markdown*

            try
            {
                DigitalHealthCheckResult result = apiInstance.MynhsToolsHeartagePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthToolsApi.MynhsToolsHeartagePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DigitalHealthCheckRequest**](DigitalHealthCheckRequest.md)| Optional description in *Markdown* | 

### Return type

[**DigitalHealthCheckResult**](DigitalHealthCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="posthealthcheck"></a>
# **PostHealthCheck**
> DigitalHealthCheckResult PostHealthCheck (DigitalHealthCheckRequest body)

Run a health check on provided data

**Does not store anything**, just returns response

### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class PostHealthCheckExample
    {
        public void main()
        {
            var apiInstance = new DigitalHealthToolsApi();
            var body = new DigitalHealthCheckRequest(); // DigitalHealthCheckRequest | Optional description in *Markdown*

            try
            {
                // Run a health check on provided data
                DigitalHealthCheckResult result = apiInstance.PostHealthCheck(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthToolsApi.PostHealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DigitalHealthCheckRequest**](DigitalHealthCheckRequest.md)| Optional description in *Markdown* | 

### Return type

[**DigitalHealthCheckResult**](DigitalHealthCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
