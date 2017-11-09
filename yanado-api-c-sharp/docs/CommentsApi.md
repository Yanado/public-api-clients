# IO.Swagger..CommentsApi

All URIs are relative to *https://api.yanado.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetComments**](CommentsApi.md#getcomments) | **GET** /public-api/comments | Get comments


<a name="getcomments"></a>
# **GetComments**
> List<Comment> GetComments (string listId, string query)

Get comments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCommentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: X-API-Key
            Configuration.Default.ApiKey.Add("X-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-API-Key", "Bearer");

            var apiInstance = new CommentsApi();
            var listId = listId_example;  // string | List id (optional) 
            var query = query_example;  // string | Query (optional) 

            try
            {
                // Get comments
                List&lt;Comment&gt; result = apiInstance.GetComments(listId, query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.GetComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listId** | **string**| List id | [optional] 
 **query** | **string**| Query | [optional] 

### Return type

[**List<Comment>**](Comment.md)

### Authorization

[X-API-Key](../README.md#X-API-Key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

