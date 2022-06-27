# mynhs.sdk.Api.DigitalHealthChecksSubmissionsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdDigitalhealthchecksGet**](DigitalHealthChecksSubmissionsApi.md#mynhsuseriddigitalhealthchecksget) | **GET** /mynhs/{userId}/digitalhealthchecks | 
[**MynhsUserIdDigitalhealthchecksSubmissionsPost**](DigitalHealthChecksSubmissionsApi.md#mynhsuseriddigitalhealthcheckssubmissionspost) | **POST** /mynhs/{userId}/digitalhealthchecks/submissions | 
[**MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGet**](DigitalHealthChecksSubmissionsApi.md#mynhsuseriddigitalhealthcheckssubmissionssubmissionidget) | **GET** /mynhs/{userId}/digitalhealthchecks/submissions/{submissionId} | 
[**MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPut**](DigitalHealthChecksSubmissionsApi.md#mynhsuseriddigitalhealthcheckssubmissionssubmissionidput) | **PUT** /mynhs/{userId}/digitalhealthchecks/submissions/{submissionId} | 
[**MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPut**](DigitalHealthChecksSubmissionsApi.md#mynhsuseriddigitalhealthcheckssubmissionssubmissionidsubmitput) | **PUT** /mynhs/{userId}/digitalhealthchecks/submissions/{submissionId}/submit | 

<a name="mynhsuseriddigitalhealthchecksget"></a>
# **MynhsUserIdDigitalhealthchecksGet**
> NhsProfile MynhsUserIdDigitalhealthchecksGet (string userId, int? skip = null, int? limit = null)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var skip = 56;  // int? | The number of items to skip before starting to collect the result set. (optional) 
            var limit = 56;  // int? | The numbers of items to return. (optional)  (default to 20)

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksGet(userId, skip, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksSubmissionsApi.MynhsUserIdDigitalhealthchecksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **skip** | **int?**| The number of items to skip before starting to collect the result set. | [optional] 
 **limit** | **int?**| The numbers of items to return. | [optional] [default to 20]

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseriddigitalhealthcheckssubmissionspost"></a>
# **MynhsUserIdDigitalhealthchecksSubmissionsPost**
> NhsProfile MynhsUserIdDigitalhealthchecksSubmissionsPost (DigitalHealthCheckRequestAll body, string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksSubmissionsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksSubmissionsApi();
            var body = new DigitalHealthCheckRequestAll(); // DigitalHealthCheckRequestAll | Returns an analysis of the given blood pressure reading.
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksSubmissionsPost(body, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksSubmissionsApi.MynhsUserIdDigitalhealthchecksSubmissionsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DigitalHealthCheckRequestAll**](DigitalHealthCheckRequestAll.md)| Returns an analysis of the given blood pressure reading. | 
 **userId** | **string**| The User Id to access | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseriddigitalhealthcheckssubmissionssubmissionidget"></a>
# **MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGet**
> NhsProfile MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGet (string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGet(userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksSubmissionsApi.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **submissionId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseriddigitalhealthcheckssubmissionssubmissionidput"></a>
# **MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPut**
> NhsProfile MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPut (DigitalHealthCheckRequest body, string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksSubmissionsApi();
            var body = new DigitalHealthCheckRequest(); // DigitalHealthCheckRequest | Returns an analysis of the given blood pressure reading.
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPut(body, userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksSubmissionsApi.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DigitalHealthCheckRequest**](DigitalHealthCheckRequest.md)| Returns an analysis of the given blood pressure reading. | 
 **userId** | **string**| The User Id to access | 
 **submissionId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseriddigitalhealthcheckssubmissionssubmissionidsubmitput"></a>
# **MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPut**
> SubmissionResponse MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPut (string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                SubmissionResponse result = apiInstance.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPut(userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksSubmissionsApi.MynhsUserIdDigitalhealthchecksSubmissionsSubmissionIdSubmitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **submissionId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**SubmissionResponse**](SubmissionResponse.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
