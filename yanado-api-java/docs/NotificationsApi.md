# NotificationsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getNotifications**](NotificationsApi.md#getNotifications) | **GET** /public-api/notifications/{type} | Get notifications


<a name="getNotifications"></a>
# **getNotifications**
> List&lt;Notification&gt; getNotifications(type, anyUser, listId)

Get notifications

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.NotificationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

NotificationsApi apiInstance = new NotificationsApi();
String type = "type_example"; // String | Notification type
Boolean anyUser = false; // Boolean | Any user
String listId = "listId_example"; // String | List id
try {
    List<Notification> result = apiInstance.getNotifications(type, anyUser, listId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NotificationsApi#getNotifications");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Notification type | [enum: ASSIGNEE, STATE, PRIORITY, DUEDATE, REMINDER, DETAILS]
 **anyUser** | **Boolean**| Any user | [optional] [default to false]
 **listId** | **String**| List id | [optional]

### Return type

[**List&lt;Notification&gt;**](Notification.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

