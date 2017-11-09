# IO.Swagger..EmailtasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEmailTasks**](EmailtasksApi.md#getemailtasks) | **GET** /public-api/email-tasks | Get tasks with emails attached


<a name="getemailtasks"></a>
# **GetEmailTasks**
> List<EmailTask> GetEmailTasks (string listId, string assignee, string statusId, string query)

Get tasks with emails attached

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEmailTasksExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new EmailtasksApi();
            var listId = listId_example;  // string | List id (optional) 
            var assignee = assignee_example;  // string | Assignee (optional) 
            var statusId = statusId_example;  // string | Status Id (optional) 
            var query = query_example;  // string | Query (optional) 

            try
            {
                // Get tasks with emails attached
                List&lt;EmailTask&gt; result = apiInstance.GetEmailTasks(listId, assignee, statusId, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmailtasksApi.GetEmailTasks: " + e.Message );
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

[**List<EmailTask>**](EmailTask.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

