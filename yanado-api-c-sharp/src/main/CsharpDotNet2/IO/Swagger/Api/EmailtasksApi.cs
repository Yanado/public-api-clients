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
    public interface IEmailtasksApi
    {
        /// <summary>
        /// Get tasks with emails attached 
        /// </summary>
        /// <param name="listId">List id</param>
        /// <param name="assignee">Assignee</param>
        /// <param name="statusId">Status Id</param>
        /// <param name="query">Query</param>
        /// <returns>List&lt;EmailTask&gt;</returns>
        List<EmailTask> GetEmailTasks (string listId, string assignee, string statusId, string query);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class EmailtasksApi : IEmailtasksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailtasksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public EmailtasksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailtasksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailtasksApi(String basePath)
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
        /// Get tasks with emails attached 
        /// </summary>
        /// <param name="listId">List id</param> 
        /// <param name="assignee">Assignee</param> 
        /// <param name="statusId">Status Id</param> 
        /// <param name="query">Query</param> 
        /// <returns>List&lt;EmailTask&gt;</returns>            
        public List<EmailTask> GetEmailTasks (string listId, string assignee, string statusId, string query)
        {
            
    
            var path = "/public-api/email-tasks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetEmailTasks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEmailTasks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<EmailTask>) ApiClient.Deserialize(response.Content, typeof(List<EmailTask>), response.Headers);
        }
    
    }
}
