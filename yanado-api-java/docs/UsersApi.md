# UsersApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getUsers**](UsersApi.md#getUsers) | **GET** /public-api/users | Get users from a team
[**getUsersFromList**](UsersApi.md#getUsersFromList) | **GET** /public-api/lists/{listId}/users | Get users from a list


<a name="getUsers"></a>
# **getUsers**
> List&lt;User&gt; getUsers(listId)

Get users from a team

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

UsersApi apiInstance = new UsersApi();
String listId = "listId_example"; // String | List id
try {
    List<User> result = apiInstance.getUsers(listId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#getUsers");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **String**| List id | [optional]

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getUsersFromList"></a>
# **getUsersFromList**
> List&lt;User&gt; getUsersFromList(listId)

Get users from a list

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

UsersApi apiInstance = new UsersApi();
String listId = "listId_example"; // String | List id
try {
    List<User> result = apiInstance.getUsersFromList(listId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#getUsersFromList");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **String**| List id |

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

