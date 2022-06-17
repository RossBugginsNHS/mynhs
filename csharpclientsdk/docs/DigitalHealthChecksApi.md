# IO.Swagger.Api.DigitalHealthChecksApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyDigitalhealthchecksHealthcheckidAgeGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidageget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/age | 
[**MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidbloodpressureget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/bloodpressure | 
[**MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidbloodsugarget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/bloodsugar | 
[**MynhsMyDigitalhealthchecksHealthcheckidColesterolGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidcolesterolget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/colesterol | 
[**MynhsMyDigitalhealthchecksHealthcheckidGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid} | 
[**MynhsMyDigitalhealthchecksHealthcheckidHeightGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidheightget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/height | 
[**MynhsMyDigitalhealthchecksHealthcheckidWeightGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidweightget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/weight | 
[**MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGet**](DigitalHealthChecksApi.md#mynhsmydigitalhealthcheckshealthcheckidwellnessquestionsget) | **GET** /mynhs/my/digitalhealthchecks/{healthcheckid}/wellnessquestions | 

<a name="mynhsmydigitalhealthcheckshealthcheckidageget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidAgeGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidAgeGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidAgeGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidAgeGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidAgeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidbloodpressureget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidBloodpressureGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidbloodsugarget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidBloodsugarGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidcolesterolget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidColesterolGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidColesterolGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidColesterolGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidColesterolGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidColesterolGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidheightget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidHeightGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidHeightGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidHeightGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidHeightGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidHeightGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidweightget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidWeightGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidWeightGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidWeightGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidWeightGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidWeightGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsmydigitalhealthcheckshealthcheckidwellnessquestionsget"></a>
# **MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGet**
> NhsProfile MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGet (string healthcheckid)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DigitalHealthChecksApi();
            var healthcheckid = healthcheckid_example;  // string | 

            try
            {
                NhsProfile result = apiInstance.MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGet(healthcheckid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DigitalHealthChecksApi.MynhsMyDigitalhealthchecksHealthcheckidWellnessquestionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **healthcheckid** | **string**|  | 

### Return type

[**NhsProfile**](NhsProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
