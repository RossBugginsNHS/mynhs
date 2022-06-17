# mynhs.sdk.Api.MedicalRecordsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyMedicalrecordsDetailedNhsRequestRecordsPost**](MedicalRecordsApi.md#mynhsmymedicalrecordsdetailednhsrequestrecordspost) | **POST** /mynhs/my/medicalrecords/detailed/nhs/requestRecords | 
[**MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGet**](MedicalRecordsApi.md#mynhsmymedicalrecordsdetailednhsrequestrecordsrequestidget) | **GET** /mynhs/my/medicalrecords/detailed/nhs/requestRecords/{requestId} | 
[**MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut**](MedicalRecordsApi.md#mynhsmymedicalrecordsdetailednhsrequestrecordsrequestidsubmitput) | **PUT** /mynhs/my/medicalrecords/detailed/nhs/requestRecords/{requestId}/submit | 
[**MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet**](MedicalRecordsApi.md#mynhsmymedicalrecordsdetailednhsrequestrecordsresultsresultidget) | **GET** /mynhs/my/medicalrecords/detailed/nhs/requestRecords/results/{resultId} | 
[**MynhsMyMedicalrecordsSummaryNhsGet**](MedicalRecordsApi.md#mynhsmymedicalrecordssummarynhsget) | **GET** /mynhs/my/medicalrecords/summary/nhs | 
[**MynhsMyMedicalrecordsSummaryNhsTrustIdGet**](MedicalRecordsApi.md#mynhsmymedicalrecordssummarynhstrustidget) | **GET** /mynhs/my/medicalrecords/summary/nhs/{trustId} | 

<a name="mynhsmymedicalrecordsdetailednhsrequestrecordspost"></a>
# **MynhsMyMedicalrecordsDetailedNhsRequestRecordsPost**
> MyNhsProfile MynhsMyMedicalrecordsDetailedNhsRequestRecordsPost ()



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsDetailedNhsRequestRecordsPostExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsDetailedNhsRequestRecordsPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsDetailedNhsRequestRecordsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmymedicalrecordsdetailednhsrequestrecordsrequestidget"></a>
# **MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGet**
> MyNhsProfile MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGet (string requestId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var requestId = requestId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGet(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmymedicalrecordsdetailednhsrequestrecordsrequestidsubmitput"></a>
# **MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut**
> MyNhsProfile MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut (string requestId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPutExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var requestId = requestId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsDetailedNhsRequestRecordsRequestIdSubmitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmymedicalrecordsdetailednhsrequestrecordsresultsresultidget"></a>
# **MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet**
> MyNhsProfile MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet (string resultId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var resultId = resultId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet(resultId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsDetailedNhsRequestRecordsResultsResultIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resultId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmymedicalrecordssummarynhsget"></a>
# **MynhsMyMedicalrecordsSummaryNhsGet**
> MyNhsProfile MynhsMyMedicalrecordsSummaryNhsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsSummaryNhsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsSummaryNhsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsSummaryNhsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmymedicalrecordssummarynhstrustidget"></a>
# **MynhsMyMedicalrecordsSummaryNhsTrustIdGet**
> MyNhsProfile MynhsMyMedicalrecordsSummaryNhsTrustIdGet (string trustId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyMedicalrecordsSummaryNhsTrustIdGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MedicalRecordsApi();
            var trustId = trustId_example;  // string | 

            try
            {
                MyNhsProfile result = apiInstance.MynhsMyMedicalrecordsSummaryNhsTrustIdGet(trustId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MedicalRecordsApi.MynhsMyMedicalrecordsSummaryNhsTrustIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **trustId** | **string**|  | 

### Return type

[**MyNhsProfile**](MyNhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
