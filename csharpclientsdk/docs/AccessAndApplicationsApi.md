# IO.Swagger.Api.AccessAndApplicationsApi

All URIs are relative to *https://virtserver.swaggerhub.com/NHSX/MyNhs/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MynhsApplicationsGet**](AccessAndApplicationsApi.md#mynhsapplicationsget) | **GET** /mynhs/applications | 
[**MynhsMyUserGet**](AccessAndApplicationsApi.md#mynhsmyuserget) | **GET** /mynhs/my/user | 
[**MynhsOwnersGet**](AccessAndApplicationsApi.md#mynhsownersget) | **GET** /mynhs/owners | 
[**MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGet**](AccessAndApplicationsApi.md#mynhstennantororganisationorthenameforwhatrecordsarelinkedtoget) | **GET** /mynhs/tennantOrOrganisationOrTheNameForWhatRecordsAreLinkedTo | 
[**MynhsUserIdUserGet**](AccessAndApplicationsApi.md#mynhsuseriduserget) | **GET** /mynhs/{userId}/user | 
[**MynhsUsersGet**](AccessAndApplicationsApi.md#mynhsusersget) | **GET** /mynhs/users | 

<a name="mynhsapplicationsget"></a>
# **MynhsApplicationsGet**
> NhsProfile MynhsApplicationsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsApplicationsGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsApplicationsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsApplicationsGet: " + e.Message );
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
<a name="mynhsmyuserget"></a>
# **MynhsMyUserGet**
> UserProfile MynhsMyUserGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsMyUserGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();

            try
            {
                UserProfile result = apiInstance.MynhsMyUserGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsMyUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsownersget"></a>
# **MynhsOwnersGet**
> NhsProfile MynhsOwnersGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsOwnersGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsOwnersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsOwnersGet: " + e.Message );
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
<a name="mynhstennantororganisationorthenameforwhatrecordsarelinkedtoget"></a>
# **MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGet**
> NhsProfile MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();

            try
            {
                NhsProfile result = apiInstance.MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsTennantOrOrganisationOrTheNameForWhatRecordsAreLinkedToGet: " + e.Message );
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
<a name="mynhsuseriduserget"></a>
# **MynhsUserIdUserGet**
> UserProfile MynhsUserIdUserGet (string userId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsUserIdUserGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();
            var userId = userId_example;  // string | 

            try
            {
                UserProfile result = apiInstance.MynhsUserIdUserGet(userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsUserIdUserGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="mynhsusersget"></a>
# **MynhsUsersGet**
> UserProfile MynhsUsersGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MynhsUsersGetExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: OAuth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AccessAndApplicationsApi();

            try
            {
                UserProfile result = apiInstance.MynhsUsersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccessAndApplicationsApi.MynhsUsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserProfile**](UserProfile.md)

### Authorization

[OAuth2](../README.md#OAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
