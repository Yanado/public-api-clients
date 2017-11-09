# ComYanadoPublicApi::ListsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_lists**](ListsApi.md#get_lists) | **GET** /public-api/lists | Get lists


# **get_lists**
> Array&lt;Array&gt; get_lists

Get lists

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

api_instance = ComYanadoPublicApi::ListsApi.new

begin
  #Get lists
  result = api_instance.get_lists
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling ListsApi->get_lists: #{e}"
end
```

### Parameters
This endpoint does not need any parameter.

### Return type

**Array&lt;Array&gt;**

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



