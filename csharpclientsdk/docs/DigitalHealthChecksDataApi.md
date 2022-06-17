# IO.Swagger.Api.DigitalHealthChecksDataApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyDigitalhealthchecksGet**](DigitalHealthChecksDataApi.md#mynhsmydigitalhealthchecksget) | **GET** /mynhs/my/digitalhealthchecks | 
[**MynhsMyDigitalhealthchecksSubmissionsPost**](DigitalHealthChecksDataApi.md#mynhsmydigitalhealthcheckssubmissionspost) | **POST** /mynhs/my/digitalhealthchecks/submissions | 
[**MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGet**](DigitalHealthChecksDataApi.md#mynhsmydigitalhealthcheckssubmissionssubmissionidget) | **GET** /mynhs/my/digitalhealthchecks/submissions/{submissionId} | 
[**MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPut**](DigitalHealthChecksDataApi.md#mynhsmydigitalhealthcheckssubmissionssubmissionidput) | **PUT** /mynhs/my/digitalhealthchecks/submissions/{submissionId} | 
[**MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPut**](DigitalHealthChecksDataApi.md#mynhsmydigitalhealthcheckssubmissionssubmissionidsubmitput) | **PUT** /mynhs/my/digitalhealthchecks/submissions/{submissionId}/submit | 

<a name="mynhsmydigitalhealthchecksget"></a>
# **MynhsMyDigitalhealthchecksGet**
> NhsProfile MynhsMyDigitalhealthchecksGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksDataApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksDataApi.MynhsMyDigitalhealthchecksGet: " + e.Message );
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
<a name="mynhsmydigitalhealthcheckssubmissionspost"></a>
# **MynhsMyDigitalhealthchecksSubmissionsPost**
> NhsProfile MynhsMyDigitalhealthchecksSubmissionsPost ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksSubmissionsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksDataApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksSubmissionsPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksDataApi.MynhsMyDigitalhealthchecksSubmissionsPost: " + e.Message );
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
<a name="mynhsmydigitalhealthcheckssubmissionssubmissionidget"></a>
# **MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGet**
> NhsProfile MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGet (string submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksDataApi();
            var submissionId = submissionId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGet(submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksDataApi.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckssubmissionssubmissionidput"></a>
# **MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPut**
> NhsProfile MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPut (string submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksDataApi();
            var submissionId = submissionId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPut(submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksDataApi.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckssubmissionssubmissionidsubmitput"></a>
# **MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPut**
> NhsProfile MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPut (string submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksDataApi();
            var submissionId = submissionId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPut(submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksDataApi.MynhsMyDigitalhealthchecksSubmissionsSubmissionIdSubmitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **submissionId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
