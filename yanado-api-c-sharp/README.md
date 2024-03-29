# IO.Swagger - the C# library for the Yanado REST API

REST API for Yanado

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- SDK version: 1.0.0
- Build date: 2017-11-21T10:08:50.996Z
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen
    For more information, please visit [https://yanado.com](https://yanado.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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
                List<Comment> result = apiInstance.GetComments(listId, query);
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.yanado.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CommentsApi* | [**GetComments**](docs/CommentsApi.md#getcomments) | **GET** /public-api/comments | Get comments
*EmailtasksApi* | [**GetEmailTasks**](docs/EmailtasksApi.md#getemailtasks) | **GET** /public-api/email-tasks | Get tasks with emails attached
*ListsApi* | [**GetLists**](docs/ListsApi.md#getlists) | **GET** /public-api/lists | Get lists
*NotificationsApi* | [**GetNotifications**](docs/NotificationsApi.md#getnotifications) | **GET** /public-api/notifications/{type} | Get notifications
*StatusesApi* | [**GetStatuses**](docs/StatusesApi.md#getstatuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list
*TasksApi* | [**CreateTask**](docs/TasksApi.md#createtask) | **POST** /public-api/tasks | Create task
*TasksApi* | [**GetTask**](docs/TasksApi.md#gettask) | **GET** /public-api/tasks/{taskId} | Get task
*TasksApi* | [**GetTasks**](docs/TasksApi.md#gettasks) | **GET** /public-api/tasks | Get tasks
*TasksApi* | [**UpdateTask**](docs/TasksApi.md#updatetask) | **PUT** /public-api/tasks/{taskId} | Update task
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /public-api/users | Get users from a team
*UsersApi* | [**GetUsersFromList**](docs/UsersApi.md#getusersfromlist) | **GET** /public-api/lists/{listId}/users | Get users from a list


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.Comment](docs/Comment.md)
 - [IO.Swagger.Model.EmailTask](docs/EmailTask.md)
 - [IO.Swagger.Model.List](docs/List.md)
 - [IO.Swagger.Model.Notification](docs/Notification.md)
 - [IO.Swagger.Model.RequestTask](docs/RequestTask.md)
 - [IO.Swagger.Model.Status](docs/Status.md)
 - [IO.Swagger.Model.Task](docs/Task.md)
 - [IO.Swagger.Model.UpdateRequestTask](docs/UpdateRequestTask.md)
 - [IO.Swagger.Model.User](docs/User.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="X-API-Key"></a>
### X-API-Key

- **Type**: API key
- **API key parameter name**: X-API-Key
- **Location**: HTTP header

