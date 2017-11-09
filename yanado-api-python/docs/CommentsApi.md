# com_yanado_public_api.CommentsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_comments**](CommentsApi.md#get_comments) | **GET** /public-api/comments | Get comments


# **get_comments**
> list[Comment] get_comments(list_id=list_id, query=query)

Get comments

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
api_instance = com_yanado_public_api.CommentsApi()
list_id = 'list_id_example' # str | List id (optional)
query = 'query_example' # str | Query (optional)

try: 
    # Get comments
    api_response = api_instance.get_comments(list_id=list_id, query=query)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentsApi->get_comments: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **str**| List id | [optional] 
 **query** | **str**| Query | [optional] 

### Return type

[**list[Comment]**](Comment.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

