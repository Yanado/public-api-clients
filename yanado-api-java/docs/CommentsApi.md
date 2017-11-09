# CommentsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getComments**](CommentsApi.md#getComments) | **GET** /public-api/comments | Get comments


<a name="getComments"></a>
# **getComments**
> List&lt;Comment&gt; getComments(listId, query)

Get comments

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.CommentsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

CommentsApi apiInstance = new CommentsApi();
String listId = "listId_example"; // String | List id
String query = "query_example"; // String | Query
try {
    List<Comment> result = apiInstance.getComments(listId, query);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CommentsApi#getComments");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **String**| List id | [optional]
 **query** | **String**| Query | [optional]

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

