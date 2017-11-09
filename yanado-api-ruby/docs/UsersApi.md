# ComYanadoPublicApi::UsersApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_users**](UsersApi.md#get_users) | **GET** /public-api/users | Get users from a team
[**get_users_from_list**](UsersApi.md#get_users_from_list) | **GET** /public-api/lists/{listId}/users | Get users from a list


# **get_users**
> Array&lt;User&gt; get_users(opts)

Get users from a team

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

api_instance = ComYanadoPublicApi::UsersApi.new

opts = { 
  list_id: "list_id_example" # String | List id
}

begin
  #Get users from a team
  result = api_instance.get_users(opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling UsersApi->get_users: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **String**| List id | [optional] 

### Return type

[**Array&lt;User&gt;**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **get_users_from_list**
> Array&lt;User&gt; get_users_from_list(list_id)

Get users from a list

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

api_instance = ComYanadoPublicApi::UsersApi.new

list_id = "list_id_example" # String | List id


begin
  #Get users from a list
  result = api_instance.get_users_from_list(list_id)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling UsersApi->get_users_from_list: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list_id** | **String**| List id | 

### Return type

[**Array&lt;User&gt;**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



