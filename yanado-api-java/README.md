# public-api

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.yanado</groupId>
    <artifactId>public-api</artifactId>
    <version>0.1</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.yanado:public-api:0.1"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/public-api-0.1.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import com.yanado.invoker.*;
import com.yanado.invoker.auth.*;
import com.yanado.model.*;
import com.yanado.api.CommentsApi;

import java.io.File;
import java.util.*;

public class CommentsApiExample {

    public static void main(String[] args) {
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
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://api.yanado.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CommentsApi* | [**getComments**](docs/CommentsApi.md#getComments) | **GET** /public-api/comments | Get comments
*EmailTasksApi* | [**getEmailTasks**](docs/EmailTasksApi.md#getEmailTasks) | **GET** /public-api/email-tasks | Get tasks with emails attached
*ListsApi* | [**getLists**](docs/ListsApi.md#getLists) | **GET** /public-api/lists | Get lists
*NotificationsApi* | [**getNotifications**](docs/NotificationsApi.md#getNotifications) | **GET** /public-api/notifications/{type} | Get notifications
*StatusesApi* | [**getStatuses**](docs/StatusesApi.md#getStatuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list
*TasksApi* | [**createTask**](docs/TasksApi.md#createTask) | **POST** /public-api/tasks | Create task
*TasksApi* | [**getTask**](docs/TasksApi.md#getTask) | **GET** /public-api/tasks/{taskId} | Get task
*TasksApi* | [**getTasks**](docs/TasksApi.md#getTasks) | **GET** /public-api/tasks | Get tasks
*TasksApi* | [**updateTask**](docs/TasksApi.md#updateTask) | **PUT** /public-api/tasks/{taskId} | Update task
*UsersApi* | [**getUsers**](docs/UsersApi.md#getUsers) | **GET** /public-api/users | Get users from a team
*UsersApi* | [**getUsersFromList**](docs/UsersApi.md#getUsersFromList) | **GET** /public-api/lists/{listId}/users | Get users from a list


## Documentation for Models

 - [Comment](docs/Comment.md)
 - [EmailTask](docs/EmailTask.md)
 - [Notification](docs/Notification.md)
 - [RequestTask](docs/RequestTask.md)
 - [Status](docs/Status.md)
 - [Task](docs/Task.md)
 - [UpdateRequestTask](docs/UpdateRequestTask.md)
 - [User](docs/User.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### X-API-Key

- **Type**: API key
- **API key parameter name**: X-API-Key
- **Location**: HTTP header


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

prle@yanado.com

