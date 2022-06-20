# mynhs.sdk.Api.ObservationsSubmissionsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdObservationsSubmissionsGet**](ObservationsSubmissionsApi.md#mynhsuseridobservationssubmissionsget) | **GET** /mynhs/{userId}/observations/submissions | 
[**MynhsUserIdObservationsSubmissionsPost**](ObservationsSubmissionsApi.md#mynhsuseridobservationssubmissionspost) | **POST** /mynhs/{userId}/observations/submissions | 
[**MynhsUserIdObservationsSubmissionsSubmissionIdGet**](ObservationsSubmissionsApi.md#mynhsuseridobservationssubmissionssubmissionidget) | **GET** /mynhs/{userId}/observations/submissions/{submissionId} | 
[**MynhsUserIdObservationsSubmissionsSubmissionIdPut**](ObservationsSubmissionsApi.md#mynhsuseridobservationssubmissionssubmissionidput) | **PUT** /mynhs/{userId}/observations/submissions/{submissionId} | 
[**MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut**](ObservationsSubmissionsApi.md#mynhsuseridobservationssubmissionssubmissionidsubmitput) | **PUT** /mynhs/{userId}/observations/submissions/{submissionId}/submit | 

<a name="mynhsuseridobservationssubmissionsget"></a>
# **MynhsUserIdObservationsSubmissionsGet**
> NhsProfile MynhsUserIdObservationsSubmissionsGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSubmissionsGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSubmissionsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsUserIdObservationsSubmissionsGet: " + e.Message );
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
<a name="mynhsuseridobservationssubmissionspost"></a>
# **MynhsUserIdObservationsSubmissionsPost**
> NhsProfile MynhsUserIdObservationsSubmissionsPost (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSubmissionsPostExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSubmissionsPost(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsUserIdObservationsSubmissionsPost: " + e.Message );
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
<a name="mynhsuseridobservationssubmissionssubmissionidget"></a>
# **MynhsUserIdObservationsSubmissionsSubmissionIdGet**
> NhsProfile MynhsUserIdObservationsSubmissionsSubmissionIdGet (string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSubmissionsSubmissionIdGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSubmissionsSubmissionIdGet(userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsUserIdObservationsSubmissionsSubmissionIdGet: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridobservationssubmissionssubmissionidput"></a>
# **MynhsUserIdObservationsSubmissionsSubmissionIdPut**
> NhsProfile MynhsUserIdObservationsSubmissionsSubmissionIdPut (string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSubmissionsSubmissionIdPutExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSubmissionsSubmissionIdPut(userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsUserIdObservationsSubmissionsSubmissionIdPut: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridobservationssubmissionssubmissionidsubmitput"></a>
# **MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut**
> NhsProfile MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut (string userId, Guid? submissionId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPutExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var userId = userId_example;  // string | The User Id to access
            var submissionId = new Guid?(); // Guid? | 

            try
            {
                NhsProfile result = apiInstance.MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut(userId, submissionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsUserIdObservationsSubmissionsSubmissionIdSubmitPut: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
