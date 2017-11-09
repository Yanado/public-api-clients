# ComYanadoPublicApi::CommentsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_comments**](CommentsApi.md#get_comments) | **GET** /public-api/comments | Get comments


# **get_comments**
> Array&lt;Comment&gt; get_comments(opts)

Get comments

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

api_instance = ComYanadoPublicApi::CommentsApi.new

opts = { 
  list_id: "list_id_example", # String | List id
  query: "query_example" # String | Query
}

begin
  #Get comments
  result = api_instance.get_comments(opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling CommentsApi->get_comments: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **String**| List id | [optional] 
 **query** | **String**| Query | [optional] 

### Return type

[**Array&lt;Comment&gt;**](Comment.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



