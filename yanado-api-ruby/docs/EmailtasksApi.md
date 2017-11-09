# ComYanadoPublicApi::EmailtasksApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_email_tasks**](EmailtasksApi.md#get_email_tasks) | **GET** /public-api/email-tasks | Get tasks with emails attached


# **get_email_tasks**
> Array&lt;EmailTask&gt; get_email_tasks(opts)

Get tasks with emails attached

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

api_instance = ComYanadoPublicApi::EmailtasksApi.new

opts = { 
  list_id: "list_id_example", # String | List id
  assignee: "assignee_example", # String | Assignee
  status_id: "status_id_example", # String | Status Id
  query: "query_example" # String | Query
}

begin
  #Get tasks with emails attached
  result = api_instance.get_email_tasks(opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling EmailtasksApi->get_email_tasks: #{e}"
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

[**Array&lt;EmailTask&gt;**](EmailTask.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



