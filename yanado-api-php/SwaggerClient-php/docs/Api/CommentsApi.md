# com.yanado.invoker\CommentsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getComments**](CommentsApi.md#getComments) | **GET** /public-api/comments | Get comments


# **getComments**
> \com.yanado.invoker\com.yanado.model\Comment[] getComments($list_id, $query)

Get comments

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\CommentsApi();
$list_id = "list_id_example"; // string | List id
$query = "query_example"; // string | Query

try {
    $result = $api_instance->getComments($list_id, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CommentsApi->getComments: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **string**| List id | [optional]
 **query** | **string**| Query | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\Comment[]**](../Model/Comment.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

