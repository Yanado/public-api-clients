# com.yanado.invoker\StatusesApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getStatuses**](StatusesApi.md#getStatuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list


# **getStatuses**
> \com.yanado.invoker\com.yanado.model\Status[] getStatuses($list_id)

Get statuses from a list

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\StatusesApi();
$list_id = "list_id_example"; // string | List id

try {
    $result = $api_instance->getStatuses($list_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling StatusesApi->getStatuses: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **string**| List id |

### Return type

[**\com.yanado.invoker\com.yanado.model\Status[]**](../Model/Status.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

