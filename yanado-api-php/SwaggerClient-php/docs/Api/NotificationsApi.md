# com.yanado.invoker\NotificationsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getNotifications**](NotificationsApi.md#getNotifications) | **GET** /public-api/notifications/{type} | Get notifications


# **getNotifications**
> \com.yanado.invoker\com.yanado.model\Notification[] getNotifications($type, $any_user, $list_id)

Get notifications

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\NotificationsApi();
$type = "type_example"; // string | Notification type
$any_user = false; // bool | Any user
$list_id = "list_id_example"; // string | List id

try {
    $result = $api_instance->getNotifications($type, $any_user, $list_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling NotificationsApi->getNotifications: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Notification type |
 **any_user** | **bool**| Any user | [optional] [default to false]
 **list_id** | **string**| List id | [optional]

### Return type

[**\com.yanado.invoker\com.yanado.model\Notification[]**](../Model/Notification.md)

### Authorization

[X-API-Key](../../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

