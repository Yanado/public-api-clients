# EmailTasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getEmailTasks**](EmailTasksApi.md#getEmailTasks) | **GET** /public-api/email-tasks | Get tasks with emails attached


<a name="getEmailTasks"></a>
# **getEmailTasks**
> List&lt;EmailTask&gt; getEmailTasks(listId, assignee, statusId, query)

Get tasks with emails attached

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.EmailTasksApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

EmailTasksApi apiInstance = new EmailTasksApi();
String listId = "listId_example"; // String | List id
String assignee = "assignee_example"; // String | Assignee
String statusId = "statusId_example"; // String | Status Id
String query = "query_example"; // String | Query
try {
    List<EmailTask> result = apiInstance.getEmailTasks(listId, assignee, statusId, query);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EmailTasksApi#getEmailTasks");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **String**| List id | [optional]
 **assignee** | **String**| Assignee | [optional]
 **statusId** | **String**| Status Id | [optional]
 **query** | **String**| Query | [optional]

### Return type

[**List&lt;EmailTask&gt;**](EmailTask.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

