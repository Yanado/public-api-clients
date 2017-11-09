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
    public interface IUsersApi
    {
        /// <summary>
        /// Get users from a team 
        /// </summary>
        /// <param name="listId">List id</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> GetUsers (string listId);
        /// <summary>
        /// Get users from a list 
        /// </summary>
        /// <param name="listId">List id</param>
        /// <returns>List&lt;User&gt;</returns>
        List<User> GetUsersFromList (string listId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Get users from a team 
        /// </summary>
        /// <param name="listId">List id</param> 
        /// <returns>List&lt;User&gt;</returns>            
        public List<User> GetUsers (string listId)
        {
            
    
            var path = "/public-api/users";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (listId != null) queryParams.Add("listId", ApiClient.ParameterToString(listId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
        /// <summary>
        /// Get users from a list 
        /// </summary>
        /// <param name="listId">List id</param> 
        /// <returns>List&lt;User&gt;</returns>            
        public List<User> GetUsersFromList (string listId)
        {
            
            // verify the required parameter 'listId' is set
            if (listId == null) throw new ApiException(400, "Missing required parameter 'listId' when calling GetUsersFromList");
            
    
            var path = "/public-api/lists/{listId}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "listId" + "}", ApiClient.ParameterToString(listId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersFromList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUsersFromList: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<User>) ApiClient.Deserialize(response.Content, typeof(List<User>), response.Headers);
        }
    
    }
}
