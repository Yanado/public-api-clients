/*
 * Yanado REST API
 * REST API for Yanado
 *
 * OpenAPI spec version: 1.0
 * Contact: prle@yanado.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.yanado.api;

import com.yanado.invoker.ApiCallback;
import com.yanado.invoker.ApiClient;
import com.yanado.invoker.ApiException;
import com.yanado.invoker.ApiResponse;
import com.yanado.invoker.Configuration;
import com.yanado.invoker.Pair;
import com.yanado.invoker.ProgressRequestBody;
import com.yanado.invoker.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.yanado.model.Status;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class StatusesApi {
    private ApiClient apiClient;

    public StatusesApi() {
        this(Configuration.getDefaultApiClient());
    }

    public StatusesApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for getStatuses
     * @param listId List id (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getStatusesCall(String listId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/public-api/lists/{listId}/statuses"
            .replaceAll("\\{" + "listId" + "\\}", apiClient.escapeString(listId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "X-API-Key" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call getStatusesValidateBeforeCall(String listId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'listId' is set
        if (listId == null) {
            throw new ApiException("Missing the required parameter 'listId' when calling getStatuses(Async)");
        }
        
        
        com.squareup.okhttp.Call call = getStatusesCall(listId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get statuses from a list
     * 
     * @param listId List id (required)
     * @return List&lt;Status&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public List<Status> getStatuses(String listId) throws ApiException {
        ApiResponse<List<Status>> resp = getStatusesWithHttpInfo(listId);
        return resp.getData();
    }

    /**
     * Get statuses from a list
     * 
     * @param listId List id (required)
     * @return ApiResponse&lt;List&lt;Status&gt;&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<List<Status>> getStatusesWithHttpInfo(String listId) throws ApiException {
        com.squareup.okhttp.Call call = getStatusesValidateBeforeCall(listId, null, null);
        Type localVarReturnType = new TypeToken<List<Status>>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get statuses from a list (asynchronously)
     * 
     * @param listId List id (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getStatusesAsync(String listId, final ApiCallback<List<Status>> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = getStatusesValidateBeforeCall(listId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<List<Status>>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}