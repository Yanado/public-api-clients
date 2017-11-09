# com.yanado.invoker\EmailtasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getEmailTasks**](EmailtasksApi.md#getEmailTasks) | **GET** /public-api/email-tasks | Get tasks with emails attached


# **getEmailTasks**
> \com.yanado.invoker\com.yanado.model\EmailTask[] getEmailTasks($list_id, $assignee, $status_id, $query)

Get tasks with emails attached

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\EmailtasksApi();
$list_id = "list_id_example"; // string | List id
$assignee = "assignee_example"; // string | Assignee
$status_id = "status_id_example"; // string | Status Id
$query = "query_example"; // string | Query

try {
    $result = $api_instance->getEmailTasks($list_id, $assignee, $status_id, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EmailtasksApi->getEmailTasks: ', $e->getMessage(), PHP_EOL;
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

[**\com.yanado.invoker\com.yanado.model\EmailTask[]**](../Model/EmailTask.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

