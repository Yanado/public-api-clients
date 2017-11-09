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

import com.yanado.invoker.ApiException;
import com.yanado.model.Status;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for StatusesApi
 */
@Ignore
public class StatusesApiTest {

    private final StatusesApi api = new StatusesApi();

    
    /**
     * Get statuses from a list
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getStatusesTest() throws ApiException {
        String listId = null;
        List<Status> response = api.getStatuses(listId);

        // TODO: test validations
    }
    
}