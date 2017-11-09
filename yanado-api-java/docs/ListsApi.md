# ListsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getLists**](ListsApi.md#getLists) | **GET** /public-api/lists | Get lists


<a name="getLists"></a>
# **getLists**
> List&lt;List&gt; getLists()

Get lists

### Example
```java
// Import classes:
//import com.yanado.invoker.ApiClient;
//import com.yanado.invoker.ApiException;
//import com.yanado.invoker.Configuration;
//import com.yanado.invoker.auth.*;
//import com.yanado.api.ListsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: X-API-Key
ApiKeyAuth X-API-Key = (ApiKeyAuth) defaultClient.getAuthentication("X-API-Key");
X-API-Key.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//X-API-Key.setApiKeyPrefix("Token");

ListsApi apiInstance = new ListsApi();
try {
    List<List> result = apiInstance.getLists();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ListsApi#getLists");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;List&gt;**](List.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

