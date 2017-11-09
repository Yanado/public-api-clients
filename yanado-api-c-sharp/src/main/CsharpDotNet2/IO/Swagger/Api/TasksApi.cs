using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITasksApi
    {
        /// <summary>
        /// Create task 
        /// </summary>
        /// <param name="taskRequest">Body</param>
        /// <returns>Task</returns>
        Task CreateTask (RequestTask taskRequest);
        /// <summary>
        /// Get task 
        /// </summary>
        /// <param name="taskId">Task id</param>
        /// <returns>Task</returns>
        Task GetTask (string taskId);
        /// <summary>
        /// Get tasks 
        /// </summary>
        /// <param name="listId">List id</param>
        /// <param name="assignee">Assignee</param>
        /// <param name="statusId">Status Id</param>
        /// <param name="query">Query</param>
        /// <returns>List&lt;Task&gt;</returns>
        List<Task> GetTasks (string listId, string assignee, string statusId, string query);
        /// <summary>
        /// Update task 
        /// </summary>
        /// <param name="taskId">Task id</param>
        /// <param name="taskRequest">Body</param>
        /// <returns>Task</returns>
        Task UpdateTask (string taskId, UpdateRequestTask taskRequest);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TasksApi : ITasksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TasksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TasksApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Create task 
        /// </summary>
        /// <param name="taskRequest">Body</param> 
        /// <returns>Task</returns>            
        public Task CreateTask (RequestTask taskRequest)
        {
            
    
            var path = "/public-api/tasks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taskRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTask: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTask: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Task) ApiClient.Deserialize(response.Content, typeof(Task), response.Headers);
        }
    
        /// <summary>
        /// Get task 
        /// </summary>
        /// <param name="taskId">Task id</param> 
        /// <returns>Task</returns>            
        public Task GetTask (string taskId)
        {
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling GetTask");
            
    
            var path = "/public-api/tasks/{taskId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTask: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTask: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Task) ApiClient.Deserialize(response.Content, typeof(Task), response.Headers);
        }
    
        /// <summary>
        /// Get tasks 
        /// </summary>
        /// <param name="listId">List id</param> 
        /// <param name="assignee">Assignee</param> 
        /// <param name="statusId">Status Id</param> 
        /// <param name="query">Query</param> 
        /// <returns>List&lt;Task&gt;</returns>            
        public List<Task> GetTasks (string listId, string assignee, string statusId, string query)
        {
            
    
            var path = "/public-api/tasks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listId != null) queryParams.Add("listId", ApiClient.ParameterToString(listId)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (statusId != null) queryParams.Add("statusId", ApiClient.ParameterToString(statusId)); // query parameter
 if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTasks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTasks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Task>) ApiClient.Deserialize(response.Content, typeof(List<Task>), response.Headers);
        }
    
        /// <summary>
        /// Update task 
        /// </summary>
        /// <param name="taskId">Task id</param> 
        /// <param name="taskRequest">Body</param> 
        /// <returns>Task</returns>            
        public Task UpdateTask (string taskId, UpdateRequestTask taskRequest)
        {
            
            // verify the required parameter 'taskId' is set
            if (taskId == null) throw new ApiException(400, "Missing required parameter 'taskId' when calling UpdateTask");
            
    
            var path = "/public-api/tasks/{taskId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "taskId" + "}", ApiClient.ParameterToString(taskId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(taskRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTask: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTask: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Task) ApiClient.Deserialize(response.Content, typeof(Task), response.Headers);
        }
    
    }
}
