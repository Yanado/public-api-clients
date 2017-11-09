# com.yanado.invoker\ListsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getLists**](ListsApi.md#getLists) | **GET** /public-api/lists | Get lists


# **getLists**
> \com.yanado.invoker\com.yanado.model\ModelList[] getLists()

Get lists

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\ListsApi();

try {
    $result = $api_instance->getLists();
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ListsApi->getLists: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**\com.yanado.invoker\com.yanado.model\ModelList[]**](../Model/ModelList.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

