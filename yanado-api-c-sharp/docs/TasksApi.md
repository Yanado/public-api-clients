# IO.Swagger..TasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTask**](TasksApi.md#createtask) | **POST** /public-api/tasks | Create task
[**GetTask**](TasksApi.md#gettask) | **GET** /public-api/tasks/{taskId} | Get task
[**GetTasks**](TasksApi.md#gettasks) | **GET** /public-api/tasks | Get tasks
[**UpdateTask**](TasksApi.md#updatetask) | **PUT** /public-api/tasks/{taskId} | Update task


<a name="createtask"></a>
# **CreateTask**
> Task CreateTask (RequestTask taskRequest)

Create task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new TasksApi();
            var taskRequest = new RequestTask(); // RequestTask | Body (optional) 

            try
            {
                // Create task
                Task result = apiInstance.CreateTask(taskRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettask"></a>
# **GetTask**
> Task GetTask (string taskId)

Get task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | Task id

            try
            {
                // Get task
                Task result = apiInstance.GetTask(taskId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| Task id | 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettasks"></a>
# **GetTasks**
> List<Task> GetTasks (string listId, string assignee, string statusId, string query)

Get tasks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTasksExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new TasksApi();
            var listId = listId_example;  // string | List id (optional) 
            var assignee = assignee_example;  // string | Assignee (optional) 
            var statusId = statusId_example;  // string | Status Id (optional) 
            var query = query_example;  // string | Query (optional) 

            try
            {
                // Get tasks
                List&lt;Task&gt; result = apiInstance.GetTasks(listId, assignee, statusId, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| List id | [optional] 
 **assignee** | **string**| Assignee | [optional] 
 **statusId** | **string**| Status Id | [optional] 
 **query** | **string**| Query | [optional] 

### Return type

[**List<Task>**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> Task UpdateTask (string taskId, UpdateRequestTask taskRequest)

Update task

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new TasksApi();
            var taskId = taskId_example;  // string | Task id
            var taskRequest = new UpdateRequestTask(); // UpdateRequestTask | Body (optional) 

            try
            {
                // Update task
                Task result = apiInstance.UpdateTask(taskId, taskRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **taskId** | **string**| Task id | 
 **taskRequest** | [**UpdateRequestTask**](UpdateRequestTask.md)| Body | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

