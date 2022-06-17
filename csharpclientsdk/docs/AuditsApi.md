# mynhs.sdk.Api.AuditsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsMyAuditsGet**](AuditsApi.md#mynhsmyauditsget) | **GET** /mynhs/my/audits | 

<a name="mynhsmyauditsget"></a>
# **MynhsMyAuditsGet**
> NhsProfile MynhsMyAuditsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using mynhs.sdk.Api;
using mynhs.sdk.Client;
using mynhs.sdk.Model;

namespace Example
{
    public class MynhsMyAuditsGetExample
    {
        public void main()
        {
            var apiInstance = new AuditsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsMyAuditsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuditsApi.MynhsMyAuditsGet: " + e.Message );
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
