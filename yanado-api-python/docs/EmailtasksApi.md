# com_yanado_public_api.EmailtasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_email_tasks**](EmailtasksApi.md#get_email_tasks) | **GET** /public-api/email-tasks | Get tasks with emails attached


# **get_email_tasks**
> list[EmailTask] get_email_tasks(list_id=list_id, assignee=assignee, status_id=status_id, query=query)

Get tasks with emails attached

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
api_instance = com_yanado_public_api.EmailtasksApi()
list_id = 'list_id_example' # str | List id (optional)
assignee = 'assignee_example' # str | Assignee (optional)
status_id = 'status_id_example' # str | Status Id (optional)
query = 'query_example' # str | Query (optional)

try: 
    # Get tasks with emails attached
    api_response = api_instance.get_email_tasks(list_id=list_id, assignee=assignee, status_id=status_id, query=query)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailtasksApi->get_email_tasks: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **str**| List id | [optional] 
 **assignee** | **str**| Assignee | [optional] 
 **status_id** | **str**| Status Id | [optional] 
 **query** | **str**| Query | [optional] 

### Return type

[**list[EmailTask]**](EmailTask.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

