# com_yanado_public_api.NotificationsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_notifications**](NotificationsApi.md#get_notifications) | **GET** /public-api/notifications/{type} | Get notifications


# **get_notifications**
> list[Notification] get_notifications(type, any_user=any_user, list_id=list_id)

Get notifications

### Example 
```python
from __future__ import print_function
import time
import com_yanado_public_api
from com_yanado_public_api.rest import ApiException
from pprint import pprint

# Configure API key authorization: X-API-Key
com_yanado_public_api.configuration.api_key['X-API-Key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# com_yanado_public_api.configuration.api_key_prefix['X-API-Key'] = 'Bearer'

# create an instance of the API class
api_instance = com_yanado_public_api.NotificationsApi()
type = 'type_example' # str | Notification type
any_user = false # bool | Any user (optional) (default to false)
list_id = 'list_id_example' # str | List id (optional)

try: 
    # Get notifications
    api_response = api_instance.get_notifications(type, any_user=any_user, list_id=list_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationsApi->get_notifications: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **str**| Notification type | 
 **any_user** | **bool**| Any user | [optional] [default to false]
 **list_id** | **str**| List id | [optional] 

### Return type

[**list[Notification]**](Notification.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

