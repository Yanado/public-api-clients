# StatusesApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getStatuses**](StatusesApi.md#getStatuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list


<a name="getStatuses"></a>
# **getStatuses**
> List&lt;Status&gt; getStatuses(listId)

Get statuses from a list

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.StatusesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

StatusesApi apiInstance = new StatusesApi();
String listId = "listId_example"; // String | List id
try {
    List<Status> result = apiInstance.getStatuses(listId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling StatusesApi#getStatuses");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **String**| List id |

### Return type

[**List&lt;Status&gt;**](Status.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

