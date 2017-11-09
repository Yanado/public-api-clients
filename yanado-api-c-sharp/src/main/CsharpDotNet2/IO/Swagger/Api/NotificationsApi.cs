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
    public interface INotificationsApi
    {
        /// <summary>
        /// Get notifications 
        /// </summary>
        /// <param name="type">Notification type</param>
        /// <param name="anyUser">Any user</param>
        /// <param name="listId">List id</param>
        /// <returns>List&lt;Notification&gt;</returns>
        List<Notification> GetNotifications (string type, bool? anyUser, string listId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationsApi : INotificationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationsApi(String basePath)
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
        /// Get notifications 
        /// </summary>
        /// <param name="type">Notification type</param> 
        /// <param name="anyUser">Any user</param> 
        /// <param name="listId">List id</param> 
        /// <returns>List&lt;Notification&gt;</returns>            
        public List<Notification> GetNotifications (string type, bool? anyUser, string listId)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling GetNotifications");
            
    
            var path = "/public-api/notifications/{type}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (anyUser != null) queryParams.Add("anyUser", ApiClient.ParameterToString(anyUser)); // query parameter
 if (listId != null) queryParams.Add("listId", ApiClient.ParameterToString(listId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "X-API-Key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotifications: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetNotifications: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Notification>) ApiClient.Deserialize(response.Content, typeof(List<Notification>), response.Headers);
        }
    
    }
}
