# mynhs.sdk.Api.ObservationsSubmissionsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyObservationsSubmissionsGet**](ObservationsSubmissionsApi.md#mynhsmyobservationssubmissionsget) | **GET** /mynhs/my/observations/submissions | 
[**MynhsMyObservationsSubmissionsNewObsIdGet**](ObservationsSubmissionsApi.md#mynhsmyobservationssubmissionsnewobsidget) | **GET** /mynhs/my/observations/submissions/{newObsId} | 
[**MynhsMyObservationsSubmissionsNewObsIdPut**](ObservationsSubmissionsApi.md#mynhsmyobservationssubmissionsnewobsidput) | **PUT** /mynhs/my/observations/submissions/{newObsId} | 
[**MynhsMyObservationsSubmissionsNewObsIdSubmitPut**](ObservationsSubmissionsApi.md#mynhsmyobservationssubmissionsnewobsidsubmitput) | **PUT** /mynhs/my/observations/submissions/{newObsId}/submit | 
[**MynhsMyObservationsSubmissionsPost**](ObservationsSubmissionsApi.md#mynhsmyobservationssubmissionspost) | **POST** /mynhs/my/observations/submissions | 

<a name="mynhsmyobservationssubmissionsget"></a>
# **MynhsMyObservationsSubmissionsGet**
> NhsProfile MynhsMyObservationsSubmissionsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyObservationsSubmissionsGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSubmissionsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsMyObservationsSubmissionsGet: " + e.Message );
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
<a name="mynhsmyobservationssubmissionsnewobsidget"></a>
# **MynhsMyObservationsSubmissionsNewObsIdGet**
> NhsProfile MynhsMyObservationsSubmissionsNewObsIdGet (string newObsId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyObservationsSubmissionsNewObsIdGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var newObsId = newObsId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSubmissionsNewObsIdGet(newObsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsMyObservationsSubmissionsNewObsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newObsId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmyobservationssubmissionsnewobsidput"></a>
# **MynhsMyObservationsSubmissionsNewObsIdPut**
> NhsProfile MynhsMyObservationsSubmissionsNewObsIdPut (string newObsId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyObservationsSubmissionsNewObsIdPutExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var newObsId = newObsId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSubmissionsNewObsIdPut(newObsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsMyObservationsSubmissionsNewObsIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newObsId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmyobservationssubmissionsnewobsidsubmitput"></a>
# **MynhsMyObservationsSubmissionsNewObsIdSubmitPut**
> NhsProfile MynhsMyObservationsSubmissionsNewObsIdSubmitPut (string newObsId)



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyObservationsSubmissionsNewObsIdSubmitPutExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();
            var newObsId = newObsId_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSubmissionsNewObsIdSubmitPut(newObsId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsMyObservationsSubmissionsNewObsIdSubmitPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **newObsId** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmyobservationssubmissionspost"></a>
# **MynhsMyObservationsSubmissionsPost**
> NhsProfile MynhsMyObservationsSubmissionsPost ()



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyObservationsSubmissionsPostExample
    {
        public void main()
        {
            var apiInstance = new ObservationsSubmissionsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsSubmissionsPost();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsSubmissionsApi.MynhsMyObservationsSubmissionsPost: " + e.Message );
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
