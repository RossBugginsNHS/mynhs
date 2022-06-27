# mynhs.sdk.Api.MedicalRecordsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost**](MedicalRecordsApi.md#mynhsuseridmedicalrecordsdetailednhsrequestrecordspost) | **POST** /mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords | 
[**MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet**](MedicalRecordsApi.md#mynhsuseridmedicalrecordsdetailednhsrequestrecordsrequestidget) | **GET** /mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/{requestId} | 
[**MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut**](MedicalRecordsApi.md#mynhsuseridmedicalrecordsdetailednhsrequestrecordsrequestidsubmitput) | **PUT** /mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/{requestId}/submit | 
[**MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet**](MedicalRecordsApi.md#mynhsuseridmedicalrecordsdetailednhsrequestrecordsresultsresultidget) | **GET** /mynhs/{userId}/medicalrecords/detailed/nhs/requestRecords/results/{resultId} | 
[**MynhsUserIdMedicalrecordsSummaryNhsGet**](MedicalRecordsApi.md#mynhsuseridmedicalrecordssummarynhsget) | **GET** /mynhs/{userId}/medicalrecords/summary/nhs | 
[**MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet**](MedicalRecordsApi.md#mynhsuseridmedicalrecordssummarynhstrustidget) | **GET** /mynhs/{userId}/medicalrecords/summary/nhs/{trustId} | 

<a name="mynhsuseridmedicalrecordsdetailednhsrequestrecordspost"></a>
# **MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost**
> MyNhsProfile MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsPost: " + e.Message );
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

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridmedicalrecordsdetailednhsrequestrecordsrequestidget"></a>
# **MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet**
> MyNhsProfile MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet (string userId, string requestId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access
            var requestId = requestId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet(userId, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **requestId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridmedicalrecordsdetailednhsrequestrecordsrequestidsubmitput"></a>
# **MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut**
> MyNhsProfile MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut (string userId, string requestId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access
            var requestId = requestId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut(userId, requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **requestId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridmedicalrecordsdetailednhsrequestrecordsresultsresultidget"></a>
# **MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet**
> MyNhsProfile MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet (string userId, string resultId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access
            var resultId = resultId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet(userId, resultId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **resultId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridmedicalrecordssummarynhsget"></a>
# **MynhsUserIdMedicalrecordsSummaryNhsGet**
> MyNhsProfile MynhsUserIdMedicalrecordsSummaryNhsGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsSummaryNhsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsSummaryNhsGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsSummaryNhsGet: " + e.Message );
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

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsuseridmedicalrecordssummarynhstrustidget"></a>
# **MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet**
> MyNhsProfile MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet (string userId, string trustId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsUserIdMedicalrecordsSummaryNhsTrustIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: MyNhsOAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var userId = userId_example;  // string | The User Id to access
            var trustId = trustId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet(userId, trustId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsUserIdMedicalrecordsSummaryNhsTrustIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**| The User Id to access | 
 **trustId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[MyNhsOAuth2](../README.md#MyNhsOAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
