# com_yanado_public_api.StatusesApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_statuses**](StatusesApi.md#get_statuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list


# **get_statuses**
> list[Status] get_statuses(list_id)

Get statuses from a list

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
api_instance = com_yanado_public_api.StatusesApi()
list_id = 'list_id_example' # str | List id

try: 
    # Get statuses from a list
    api_response = api_instance.get_statuses(list_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StatusesApi->get_statuses: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **str**| List id | 

### Return type

[**list[Status]**](Status.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

