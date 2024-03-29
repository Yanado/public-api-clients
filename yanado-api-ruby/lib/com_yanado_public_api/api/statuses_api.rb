=begin
#Yanado REST API

#REST API for Yanado

OpenAPI spec version: 1.0
Contact: prle@yanado.com
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.2.3

=end

require "uri"

module ComYanadoPublicApi
  class StatusesApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get statuses from a list
    # 
    # @param list_id List id
    # @param [Hash] opts the optional parameters
    # @return [Array<Status>]
    def get_statuses(list_id, opts = {})
      data, _status_code, _headers = get_statuses_with_http_info(list_id, opts)
      return data
    end

    # Get statuses from a list
    # 
    # @param list_id List id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<Status>, Fixnum, Hash)>] Array<Status> data, response status code and response headers
    def get_statuses_with_http_info(list_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: StatusesApi.get_statuses ..."
      end
      # verify the required parameter 'list_id' is set
      if @api_client.config.client_side_validation && list_id.nil?
        fail ArgumentError, "Missing the required parameter 'list_id' when calling StatusesApi.get_statuses"
      end
      # resource path
      local_var_path = "/public-api/lists/{listId}/statuses".sub('{' + 'listId' + '}', list_id.to_s)

      # query parameters
      query_params = {}

      # header parameters
      header_params = {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = {}

      # http body (model)
      post_body = nil
      auth_names = ['X-API-Key']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => 'Array<Status>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: StatusesApi#get_statuses\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
