<?php
/**
 * TasksApi
 * PHP version 5
 *
 * @category Class
 * @package  com.yanado.invoker
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Yanado REST API
 *
 * REST API for Yanado
 *
 * OpenAPI spec version: 1.0
 * Contact: prle@yanado.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace com.yanado.invoker\com.yanado.api;

use \com.yanado.invoker\ApiClient;
use \com.yanado.invoker\ApiException;
use \com.yanado.invoker\Configuration;
use \com.yanado.invoker\ObjectSerializer;

/**
 * TasksApi Class Doc Comment
 *
 * @category Class
 * @package  com.yanado.invoker
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TasksApi
{
    /**
     * API Client
     *
     * @var \com.yanado.invoker\ApiClient instance of the ApiClient
     */
    protected $apiClient;

    /**
     * Constructor
     *
     * @param \com.yanado.invoker\ApiClient|null $apiClient The api client to use
     */
    public function __construct(\com.yanado.invoker\ApiClient $apiClient = null)
    {
        if ($apiClient === null) {
            $apiClient = new ApiClient();
        }

        $this->apiClient = $apiClient;
    }

    /**
     * Get API client
     *
     * @return \com.yanado.invoker\ApiClient get the API client
     */
    public function getApiClient()
    {
        return $this->apiClient;
    }

    /**
     * Set the API client
     *
     * @param \com.yanado.invoker\ApiClient $apiClient set the API client
     *
     * @return TasksApi
     */
    public function setApiClient(\com.yanado.invoker\ApiClient $apiClient)
    {
        $this->apiClient = $apiClient;
        return $this;
    }

    /**
     * Operation createTask
     *
     * Create task
     *
     * @param \com.yanado.invoker\com.yanado.model\RequestTask $task_request Body (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return \com.yanado.invoker\com.yanado.model\Task
     */
    public function createTask($task_request = null)
    {
        list($response) = $this->createTaskWithHttpInfo($task_request);
        return $response;
    }

    /**
     * Operation createTaskWithHttpInfo
     *
     * Create task
     *
     * @param \com.yanado.invoker\com.yanado.model\RequestTask $task_request Body (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return array of \com.yanado.invoker\com.yanado.model\Task, HTTP status code, HTTP response headers (array of strings)
     */
    public function createTaskWithHttpInfo($task_request = null)
    {
        // parse inputs
        $resourcePath = "/public-api/tasks";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // body params
        $_tempBody = null;
        if (isset($task_request)) {
            $_tempBody = $task_request;
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('X-API-Key');
        if (strlen($apiKey) !== 0) {
            $headerParams['X-API-Key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'POST',
                $queryParams,
                $httpBody,
                $headerParams,
                '\com.yanado.invoker\com.yanado.model\Task',
                '/public-api/tasks'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\com.yanado.invoker\com.yanado.model\Task', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\com.yanado.invoker\com.yanado.model\Task', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getTask
     *
     * Get task
     *
     * @param string $task_id Task id (required)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return \com.yanado.invoker\com.yanado.model\Task
     */
    public function getTask($task_id)
    {
        list($response) = $this->getTaskWithHttpInfo($task_id);
        return $response;
    }

    /**
     * Operation getTaskWithHttpInfo
     *
     * Get task
     *
     * @param string $task_id Task id (required)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return array of \com.yanado.invoker\com.yanado.model\Task, HTTP status code, HTTP response headers (array of strings)
     */
    public function getTaskWithHttpInfo($task_id)
    {
        // verify the required parameter 'task_id' is set
        if ($task_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $task_id when calling getTask');
        }
        // parse inputs
        $resourcePath = "/public-api/tasks/{taskId}";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // path params
        if ($task_id !== null) {
            $resourcePath = str_replace(
                "{" . "taskId" . "}",
                $this->apiClient->getSerializer()->toPathValue($task_id),
                $resourcePath
            );
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('X-API-Key');
        if (strlen($apiKey) !== 0) {
            $headerParams['X-API-Key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\com.yanado.invoker\com.yanado.model\Task',
                '/public-api/tasks/{taskId}'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\com.yanado.invoker\com.yanado.model\Task', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\com.yanado.invoker\com.yanado.model\Task', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation getTasks
     *
     * Get tasks
     *
     * @param string $list_id List id (optional)
     * @param string $assignee Assignee (optional)
     * @param string $status_id Status Id (optional)
     * @param string $query Query (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return \com.yanado.invoker\com.yanado.model\Task[]
     */
    public function getTasks($list_id = null, $assignee = null, $status_id = null, $query = null)
    {
        list($response) = $this->getTasksWithHttpInfo($list_id, $assignee, $status_id, $query);
        return $response;
    }

    /**
     * Operation getTasksWithHttpInfo
     *
     * Get tasks
     *
     * @param string $list_id List id (optional)
     * @param string $assignee Assignee (optional)
     * @param string $status_id Status Id (optional)
     * @param string $query Query (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return array of \com.yanado.invoker\com.yanado.model\Task[], HTTP status code, HTTP response headers (array of strings)
     */
    public function getTasksWithHttpInfo($list_id = null, $assignee = null, $status_id = null, $query = null)
    {
        // parse inputs
        $resourcePath = "/public-api/tasks";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // query params
        if ($list_id !== null) {
            $queryParams['listId'] = $this->apiClient->getSerializer()->toQueryValue($list_id);
        }
        // query params
        if ($assignee !== null) {
            $queryParams['assignee'] = $this->apiClient->getSerializer()->toQueryValue($assignee);
        }
        // query params
        if ($status_id !== null) {
            $queryParams['statusId'] = $this->apiClient->getSerializer()->toQueryValue($status_id);
        }
        // query params
        if ($query !== null) {
            $queryParams['query'] = $this->apiClient->getSerializer()->toQueryValue($query);
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('X-API-Key');
        if (strlen($apiKey) !== 0) {
            $headerParams['X-API-Key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'GET',
                $queryParams,
                $httpBody,
                $headerParams,
                '\com.yanado.invoker\com.yanado.model\Task[]',
                '/public-api/tasks'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\com.yanado.invoker\com.yanado.model\Task[]', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\com.yanado.invoker\com.yanado.model\Task[]', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }

    /**
     * Operation updateTask
     *
     * Update task
     *
     * @param string $task_id Task id (required)
     * @param \com.yanado.invoker\com.yanado.model\UpdateRequestTask $task_request Body (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return \com.yanado.invoker\com.yanado.model\Task
     */
    public function updateTask($task_id, $task_request = null)
    {
        list($response) = $this->updateTaskWithHttpInfo($task_id, $task_request);
        return $response;
    }

    /**
     * Operation updateTaskWithHttpInfo
     *
     * Update task
     *
     * @param string $task_id Task id (required)
     * @param \com.yanado.invoker\com.yanado.model\UpdateRequestTask $task_request Body (optional)
     * @throws \com.yanado.invoker\ApiException on non-2xx response
     * @return array of \com.yanado.invoker\com.yanado.model\Task, HTTP status code, HTTP response headers (array of strings)
     */
    public function updateTaskWithHttpInfo($task_id, $task_request = null)
    {
        // verify the required parameter 'task_id' is set
        if ($task_id === null) {
            throw new \InvalidArgumentException('Missing the required parameter $task_id when calling updateTask');
        }
        // parse inputs
        $resourcePath = "/public-api/tasks/{taskId}";
        $httpBody = '';
        $queryParams = [];
        $headerParams = [];
        $formParams = [];
        $_header_accept = $this->apiClient->selectHeaderAccept(['application/json']);
        if (!is_null($_header_accept)) {
            $headerParams['Accept'] = $_header_accept;
        }
        $headerParams['Content-Type'] = $this->apiClient->selectHeaderContentType(['application/json']);

        // path params
        if ($task_id !== null) {
            $resourcePath = str_replace(
                "{" . "taskId" . "}",
                $this->apiClient->getSerializer()->toPathValue($task_id),
                $resourcePath
            );
        }
        // body params
        $_tempBody = null;
        if (isset($task_request)) {
            $_tempBody = $task_request;
        }

        // for model (json/xml)
        if (isset($_tempBody)) {
            $httpBody = $_tempBody; // $_tempBody is the method argument, if present
        } elseif (count($formParams) > 0) {
            $httpBody = $formParams; // for HTTP post (form)
        }
        // this endpoint requires API key authentication
        $apiKey = $this->apiClient->getApiKeyWithPrefix('X-API-Key');
        if (strlen($apiKey) !== 0) {
            $headerParams['X-API-Key'] = $apiKey;
        }
        // make the API Call
        try {
            list($response, $statusCode, $httpHeader) = $this->apiClient->callApi(
                $resourcePath,
                'PUT',
                $queryParams,
                $httpBody,
                $headerParams,
                '\com.yanado.invoker\com.yanado.model\Task',
                '/public-api/tasks/{taskId}'
            );

            return [$this->apiClient->getSerializer()->deserialize($response, '\com.yanado.invoker\com.yanado.model\Task', $httpHeader), $statusCode, $httpHeader];
        } catch (ApiException $e) {
            switch ($e->getCode()) {
                case 200:
                    $data = $this->apiClient->getSerializer()->deserialize($e->getResponseBody(), '\com.yanado.invoker\com.yanado.model\Task', $e->getResponseHeaders());
                    $e->setResponseObject($data);
                    break;
            }

            throw $e;
        }
    }
}