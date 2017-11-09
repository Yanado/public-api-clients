# ComYanadoPublicApi::StatusesApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_statuses**](StatusesApi.md#get_statuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list


# **get_statuses**
> Array&lt;Status&gt; get_statuses(list_id)

Get statuses from a list

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

api_instance = ComYanadoPublicApi::StatusesApi.new

list_id = "list_id_example" # String | List id


begin
  #Get statuses from a list
  result = api_instance.get_statuses(list_id)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling StatusesApi->get_statuses: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **String**| List id | 

### Return type

[**Array&lt;Status&gt;**](Status.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



