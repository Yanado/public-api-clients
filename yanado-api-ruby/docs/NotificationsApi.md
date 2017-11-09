# ComYanadoPublicApi::NotificationsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_notifications**](NotificationsApi.md#get_notifications) | **GET** /public-api/notifications/{type} | Get notifications


# **get_notifications**
> Array&lt;Notification&gt; get_notifications(type, opts)

Get notifications

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

api_instance = ComYanadoPublicApi::NotificationsApi.new

type = "type_example" # String | Notification type

opts = { 
  any_user: false, # BOOLEAN | Any user
  list_id: "list_id_example" # String | List id
}

begin
  #Get notifications
  result = api_instance.get_notifications(type, opts)
  p result
rescue ComYanadoPublicApi::ApiError => e
  puts "Exception when calling NotificationsApi->get_notifications: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Notification type | 
 **any_user** | **BOOLEAN**| Any user | [optional] [default to false]
 **list_id** | **String**| List id | [optional] 

### Return type

[**Array&lt;Notification&gt;**](Notification.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



