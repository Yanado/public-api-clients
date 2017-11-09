# com_yanado_public_api.ListsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_lists**](ListsApi.md#get_lists) | **GET** /public-api/lists | Get lists


# **get_lists**
> list[List] get_lists()

Get lists

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
api_instance = com_yanado_public_api.ListsApi()

try: 
    # Get lists
    api_response = api_instance.get_lists()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ListsApi->get_lists: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[List]**](List.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

