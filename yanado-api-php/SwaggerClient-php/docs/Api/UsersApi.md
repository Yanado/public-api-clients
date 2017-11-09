# com.yanado.invoker\UsersApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getUsers**](UsersApi.md#getUsers) | **GET** /public-api/users | Get users from a team
[**getUsersFromList**](UsersApi.md#getUsersFromList) | **GET** /public-api/lists/{listId}/users | Get users from a list


# **getUsers**
> \com.yanado.invoker\com.yanado.model\User[] getUsers($list_id)

Get users from a team

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\UsersApi();
$list_id = "list_id_example"; // string | List id

try {
    $result = $api_instance->getUsers($list_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling UsersApi->getUsers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **string**| List id | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\User[]**](../Model/User.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getUsersFromList**
> \com.yanado.invoker\com.yanado.model\User[] getUsersFromList($list_id)

Get users from a list

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\UsersApi();
$list_id = "list_id_example"; // string | List id

try {
    $result = $api_instance->getUsersFromList($list_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling UsersApi->getUsersFromList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **string**| List id |

### Return type

[**\com.yanado.invoker\com.yanado.model\User[]**](../Model/User.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

