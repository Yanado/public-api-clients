# SwaggerClient-php
REST API for Yanado

This PHP package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0
- Build package: io.swagger.codegen.languages.PhpClientCodegen
For more information, please visit [https://yanado.com](https://yanado.com)

## Requirements

PHP 5.4.0 and later

## Installation & Usage
### Composer

To install the bindings via [Composer](http://getcomposer.org/), add the following to `composer.json`:

```
{
  "repositories": [
    {
      "type": "git",
      "url": "https://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/autoload.php');
```

## Tests

To run the unit tests:

```
composer install
./vendor/bin/phpunit
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

// Configure API key authorization: X-API-Key
com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKey('X-API-Key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// com.yanado.invoker\Configuration::getDefaultConfiguration()->setApiKeyPrefix('X-API-Key', 'Bearer');

$api_instance = new com.yanado.invoker\Api\CommentsApi();
$list_id = "list_id_example"; // string | List id
$query = "query_example"; // string | Query

try {
    $result = $api_instance->getComments($list_id, $query);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CommentsApi->getComments: ', $e->getMessage(), PHP_EOL;
}

?>
```

## Documentation for API Endpoints

All URIs are relative to *https://api.yanado.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CommentsApi* | [**getComments**](docs/Api/CommentsApi.md#getcomments) | **GET** /public-api/comments | Get comments
*EmailtasksApi* | [**getEmailTasks**](docs/Api/EmailtasksApi.md#getemailtasks) | **GET** /public-api/email-tasks | Get tasks with emails attached
*ListsApi* | [**getLists**](docs/Api/ListsApi.md#getlists) | **GET** /public-api/lists | Get lists
*NotificationsApi* | [**getNotifications**](docs/Api/NotificationsApi.md#getnotifications) | **GET** /public-api/notifications/{type} | Get notifications
*StatusesApi* | [**getStatuses**](docs/Api/StatusesApi.md#getstatuses) | **GET** /public-api/lists/{listId}/statuses | Get statuses from a list
*TasksApi* | [**createTask**](docs/Api/TasksApi.md#createtask) | **POST** /public-api/tasks | Create task
*TasksApi* | [**getTask**](docs/Api/TasksApi.md#gettask) | **GET** /public-api/tasks/{taskId} | Get task
*TasksApi* | [**getTasks**](docs/Api/TasksApi.md#gettasks) | **GET** /public-api/tasks | Get tasks
*TasksApi* | [**updateTask**](docs/Api/TasksApi.md#updatetask) | **PUT** /public-api/tasks/{taskId} | Update task
*UsersApi* | [**getUsers**](docs/Api/UsersApi.md#getusers) | **GET** /public-api/users | Get users from a team
*UsersApi* | [**getUsersFromList**](docs/Api/UsersApi.md#getusersfromlist) | **GET** /public-api/lists/{listId}/users | Get users from a list


## Documentation For Models

 - [Comment](docs/Model/Comment.md)
 - [EmailTask](docs/Model/EmailTask.md)
 - [ModelList](docs/Model/ModelList.md)
 - [Notification](docs/Model/Notification.md)
 - [RequestTask](docs/Model/RequestTask.md)
 - [Status](docs/Model/Status.md)
 - [Task](docs/Model/Task.md)
 - [UpdateRequestTask](docs/Model/UpdateRequestTask.md)
 - [User](docs/Model/User.md)


## Documentation For Authorization


## X-API-Key

- **Type**: API key
- **API key parameter name**: X-API-Key
- **Location**: HTTP header


## Author

prle@yanado.com

