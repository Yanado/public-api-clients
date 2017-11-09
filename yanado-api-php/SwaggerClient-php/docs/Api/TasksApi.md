# com.yanado.invoker\TasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createTask**](TasksApi.md#createTask) | **POST** /public-api/tasks | Create task
[**getTask**](TasksApi.md#getTask) | **GET** /public-api/tasks/{taskId} | Get task
[**getTasks**](TasksApi.md#getTasks) | **GET** /public-api/tasks | Get tasks
[**updateTask**](TasksApi.md#updateTask) | **PUT** /public-api/tasks/{taskId} | Update task


# **createTask**
> \com.yanado.invoker\com.yanado.model\Task createTask($task_request)

Create task

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\TasksApi();
$task_request = new \com.yanado.invoker\com.yanado.model\RequestTask(); // \com.yanado.invoker\com.yanado.model\RequestTask | Body

try {
    $result = $api_instance->createTask($task_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->createTask: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_request** | [**\com.yanado.invoker\com.yanado.model\RequestTask**](../Model/RequestTask.md)| Body | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\Task**](../Model/Task.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getTask**
> \com.yanado.invoker\com.yanado.model\Task getTask($task_id)

Get task

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\TasksApi();
$task_id = "task_id_example"; // string | Task id

try {
    $result = $api_instance->getTask($task_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->getTask: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **string**| Task id |

### Return type

[**\com.yanado.invoker\com.yanado.model\Task**](../Model/Task.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getTasks**
> \com.yanado.invoker\com.yanado.model\Task[] getTasks($list_id, $assignee, $status_id, $query)

Get tasks

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\TasksApi();
$list_id = "list_id_example"; // string | List id
$assignee = "assignee_example"; // string | Assignee
$status_id = "status_id_example"; // string | Status Id
$query = "query_example"; // string | Query

try {
    $result = $api_instance->getTasks($list_id, $assignee, $status_id, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->getTasks: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **string**| List id | [optional]
 **assignee** | **string**| Assignee | [optional]
 **status_id** | **string**| Status Id | [optional]
 **query** | **string**| Query | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\Task[]**](../Model/Task.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **updateTask**
> \com.yanado.invoker\com.yanado.model\Task updateTask($task_id, $task_request)

Update task

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\TasksApi();
$task_id = "task_id_example"; // string | Task id
$task_request = new \com.yanado.invoker\com.yanado.model\UpdateRequestTask(); // \com.yanado.invoker\com.yanado.model\UpdateRequestTask | Body

try {
    $result = $api_instance->updateTask($task_id, $task_request);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TasksApi->updateTask: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **string**| Task id |
 **task_request** | [**\com.yanado.invoker\com.yanado.model\UpdateRequestTask**](../Model/UpdateRequestTask.md)| Body | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\Task**](../Model/Task.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

