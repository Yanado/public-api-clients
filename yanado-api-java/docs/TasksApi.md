# TasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createTask**](TasksApi.md#createTask) | **POST** /public-api/tasks | Create task
[**getTask**](TasksApi.md#getTask) | **GET** /public-api/tasks/{taskId} | Get task
[**getTasks**](TasksApi.md#getTasks) | **GET** /public-api/tasks | Get tasks
[**updateTask**](TasksApi.md#updateTask) | **PUT** /public-api/tasks/{taskId} | Update task


<a name="createTask"></a>
# **createTask**
> Task createTask(taskRequest)

Create task

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.TasksApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

TasksApi apiInstance = new TasksApi();
RequestTask taskRequest = new RequestTask(); // RequestTask | Body
try {
    Task result = apiInstance.createTask(taskRequest);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TasksApi#createTask");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskRequest** | [**RequestTask**](RequestTask.md)| Body | [optional]

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getTask"></a>
# **getTask**
> Task getTask(taskId)

Get task

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.TasksApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

TasksApi apiInstance = new TasksApi();
String taskId = "taskId_example"; // String | Task id
try {
    Task result = apiInstance.getTask(taskId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TasksApi#getTask");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **String**| Task id |

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getTasks"></a>
# **getTasks**
> List&lt;Task&gt; getTasks(listId, assignee, statusId, query)

Get tasks

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.TasksApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

TasksApi apiInstance = new TasksApi();
String listId = "listId_example"; // String | List id
String assignee = "assignee_example"; // String | Assignee
String statusId = "statusId_example"; // String | Status Id
String query = "query_example"; // String | Query
try {
    List<Task> result = apiInstance.getTasks(listId, assignee, statusId, query);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TasksApi#getTasks");
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

[**List&lt;Task&gt;**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateTask"></a>
# **updateTask**
> Task updateTask(taskId, taskRequest)

Update task

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.TasksApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

TasksApi apiInstance = new TasksApi();
String taskId = "taskId_example"; // String | Task id
UpdateRequestTask taskRequest = new UpdateRequestTask(); // UpdateRequestTask | Body
try {
    Task result = apiInstance.updateTask(taskId, taskRequest);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TasksApi#updateTask");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **String**| Task id |
 **taskRequest** | [**UpdateRequestTask**](UpdateRequestTask.md)| Body | [optional]

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

