# com_yanado_public_api.TasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create_task**](TasksApi.md#create_task) | **POST** /public-api/tasks | Create task
[**get_task**](TasksApi.md#get_task) | **GET** /public-api/tasks/{taskId} | Get task
[**get_tasks**](TasksApi.md#get_tasks) | **GET** /public-api/tasks | Get tasks
[**update_task**](TasksApi.md#update_task) | **PUT** /public-api/tasks/{taskId} | Update task


# **create_task**
> Task create_task(task_request=task_request)

Create task

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
api_instance = com_yanado_public_api.TasksApi()
task_request = com_yanado_public_api.RequestTask() # RequestTask | Body (optional)

try: 
    # Create task
    api_response = api_instance.create_task(task_request=task_request)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TasksApi->create_task: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_request** | [**RequestTask**](RequestTask.md)| Body | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_task**
> Task get_task(task_id)

Get task

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
api_instance = com_yanado_public_api.TasksApi()
task_id = 'task_id_example' # str | Task id

try: 
    # Get task
    api_response = api_instance.get_task(task_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TasksApi->get_task: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **str**| Task id | 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_tasks**
> list[Task] get_tasks(list_id=list_id, assignee=assignee, status_id=status_id, query=query)

Get tasks

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
api_instance = com_yanado_public_api.TasksApi()
list_id = 'list_id_example' # str | List id (optional)
assignee = 'assignee_example' # str | Assignee (optional)
status_id = 'status_id_example' # str | Status Id (optional)
query = 'query_example' # str | Query (optional)

try: 
    # Get tasks
    api_response = api_instance.get_tasks(list_id=list_id, assignee=assignee, status_id=status_id, query=query)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TasksApi->get_tasks: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **str**| List id | [optional] 
 **assignee** | **str**| Assignee | [optional] 
 **status_id** | **str**| Status Id | [optional] 
 **query** | **str**| Query | [optional] 

### Return type

[**list[Task]**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **update_task**
> Task update_task(task_id, task_request=task_request)

Update task

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
api_instance = com_yanado_public_api.TasksApi()
task_id = 'task_id_example' # str | Task id
task_request = com_yanado_public_api.UpdateRequestTask() # UpdateRequestTask | Body (optional)

try: 
    # Update task
    api_response = api_instance.update_task(task_id, task_request=task_request)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TasksApi->update_task: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **str**| Task id | 
 **task_request** | [**UpdateRequestTask**](UpdateRequestTask.md)| Body | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

