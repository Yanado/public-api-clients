# IO.Swagger..UsersApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUsers**](UsersApi.md#getusers) | **GET** /public-api/users | Get users from a team
[**GetUsersFromList**](UsersApi.md#getusersfromlist) | **GET** /public-api/lists/{listId}/users | Get users from a list


<a name="getusers"></a>
# **GetUsers**
> List<User> GetUsers (string listId)

Get users from a team

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new UsersApi();
            var listId = listId_example;  // string | List id (optional) 

            try
            {
                // Get users from a team
                List&lt;User&gt; result = apiInstance.GetUsers(listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| List id | [optional] 

### Return type

[**List<User>**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getusersfromlist"></a>
# **GetUsersFromList**
> List<User> GetUsersFromList (string listId)

Get users from a list

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUsersFromListExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new UsersApi();
            var listId = listId_example;  // string | List id

            try
            {
                // Get users from a list
                List&lt;User&gt; result = apiInstance.GetUsersFromList(listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUsersFromList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| List id | 

### Return type

[**List<User>**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

