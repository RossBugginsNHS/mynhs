# IO.Swagger.Api.ObservationsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyObservationsBloodpressuresGet**](ObservationsApi.md#mynhsmyobservationsbloodpressuresget) | **GET** /mynhs/my/observations/bloodpressures | 
[**MynhsMyObservationsGet**](ObservationsApi.md#mynhsmyobservationsget) | **GET** /mynhs/my/observations | 
[**MynhsMyObservationsHeightsGet**](ObservationsApi.md#mynhsmyobservationsheightsget) | **GET** /mynhs/my/observations/heights | 
[**MynhsMyObservationsWeightsGet**](ObservationsApi.md#mynhsmyobservationsweightsget) | **GET** /mynhs/my/observations/weights | 

<a name="mynhsmyobservationsbloodpressuresget"></a>
# **MynhsMyObservationsBloodpressuresGet**
> NhsProfile MynhsMyObservationsBloodpressuresGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsBloodpressuresGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsBloodpressuresGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsMyObservationsBloodpressuresGet: " + e.Message );
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
<a name="mynhsmyobservationsget"></a>
# **MynhsMyObservationsGet**
> NhsProfile MynhsMyObservationsGet (string type)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();
            var type = type_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsGet(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsMyObservationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmyobservationsheightsget"></a>
# **MynhsMyObservationsHeightsGet**
> NhsProfile MynhsMyObservationsHeightsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsHeightsGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsHeightsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsMyObservationsHeightsGet: " + e.Message );
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
<a name="mynhsmyobservationsweightsget"></a>
# **MynhsMyObservationsWeightsGet**
> NhsProfile MynhsMyObservationsWeightsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyObservationsWeightsGetExample
    {
        public void main()
        {
            var apiInstance = new ObservationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyObservationsWeightsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ObservationsApi.MynhsMyObservationsWeightsGet: " + e.Message );
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
