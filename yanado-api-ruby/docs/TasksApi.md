# ComYanadoPublicApi::TasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**create_task**](TasksApi.md#create_task) | **POST** /public-api/tasks | Create task
[**get_task**](TasksApi.md#get_task) | **GET** /public-api/tasks/{taskId} | Get task
[**get_tasks**](TasksApi.md#get_tasks) | **GET** /public-api/tasks | Get tasks
[**update_task**](TasksApi.md#update_task) | **PUT** /public-api/tasks/{taskId} | Update task


# **create_task**
> Task create_task(opts)

Create task

### Example
```ruby
# load the gem
require 'com_yanado_public_api'
# setup authorization
ComYanadoPublicApi.configure do |config|
  # Configure API key authorization: X-API-Key
  config.api_key['X-API-Key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['X-API-Key'] = 'Bearer'
end

api_instance = ComYanadoPublicApi::TasksApi.new

opts = { 
  task_request: ComYanadoPublicApi::RequestTask.new # RequestTask | Body
}

begin
  #Create task
  result = api_instance.create_task(opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling TasksApi->create_task: #{e}"
end
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



# **get_task**
> Task get_task(task_id)

Get task

### Example
```ruby
# load the gem
require 'com_yanado_public_api'
# setup authorization
ComYanadoPublicApi.configure do |config|
  # Configure API key authorization: X-API-Key
  config.api_key['X-API-Key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['X-API-Key'] = 'Bearer'
end

api_instance = ComYanadoPublicApi::TasksApi.new

task_id = "task_id_example" # String | Task id


begin
  #Get task
  result = api_instance.get_task(task_id)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling TasksApi->get_task: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **String**| Task id | 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_tasks**
> Array&lt;Task&gt; get_tasks(opts)

Get tasks

### Example
```ruby
# load the gem
require 'com_yanado_public_api'
# setup authorization
ComYanadoPublicApi.configure do |config|
  # Configure API key authorization: X-API-Key
  config.api_key['X-API-Key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['X-API-Key'] = 'Bearer'
end

api_instance = ComYanadoPublicApi::TasksApi.new

opts = { 
  list_id: "list_id_example", # String | List id
  assignee: "assignee_example", # String | Assignee
  status_id: "status_id_example", # String | Status Id
  query: "query_example" # String | Query
}

begin
  #Get tasks
  result = api_instance.get_tasks(opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling TasksApi->get_tasks: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **String**| List id | [optional] 
 **assignee** | **String**| Assignee | [optional] 
 **status_id** | **String**| Status Id | [optional] 
 **query** | **String**| Query | [optional] 

### Return type

[**Array&lt;Task&gt;**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_task**
> Task update_task(task_id, opts)

Update task

### Example
```ruby
# load the gem
require 'com_yanado_public_api'
# setup authorization
ComYanadoPublicApi.configure do |config|
  # Configure API key authorization: X-API-Key
  config.api_key['X-API-Key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['X-API-Key'] = 'Bearer'
end

api_instance = ComYanadoPublicApi::TasksApi.new

task_id = "task_id_example" # String | Task id

opts = { 
  task_request: ComYanadoPublicApi::UpdateRequestTask.new # UpdateRequestTask | Body
}

begin
  #Update task
  result = api_instance.update_task(task_id, opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling TasksApi->update_task: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **task_id** | **String**| Task id | 
 **task_request** | [**UpdateRequestTask**](UpdateRequestTask.md)| Body | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



