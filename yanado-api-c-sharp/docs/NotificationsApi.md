# IO.Swagger..NotificationsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetNotifications**](NotificationsApi.md#getnotifications) | **GET** /public-api/notifications/{type} | Get notifications


<a name="getnotifications"></a>
# **GetNotifications**
> List<Notification> GetNotifications (string type, bool? anyUser, string listId)

Get notifications

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetNotificationsExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new NotificationsApi();
            var type = type_example;  // string | Notification type
            var anyUser = true;  // bool? | Any user (optional)  (default to false)
            var listId = listId_example;  // string | List id (optional) 

            try
            {
                // Get notifications
                List&lt;Notification&gt; result = apiInstance.GetNotifications(type, anyUser, listId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationsApi.GetNotifications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Notification type | 
 **anyUser** | **bool?**| Any user | [optional] [default to false]
 **listId** | **string**| List id | [optional] 

### Return type

[**List<Notification>**](Notification.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

