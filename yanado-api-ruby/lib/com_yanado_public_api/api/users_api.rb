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
  class UsersApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get users from a team
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :list_id List id
    # @return [Array<User>]
    def get_users(opts = {})
      data, _status_code, _headers = get_users_with_http_info(opts)
      return data
    end

    # Get users from a team
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :list_id List id
    # @return [Array<(Array<User>, Fixnum, Hash)>] Array<User> data, response status code and response headers
    def get_users_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UsersApi.get_users ..."
      end
      # resource path
      local_var_path = "/public-api/users"

      # query parameters
      query_params = {}
      query_params[:'listId'] = opts[:'list_id'] if !opts[:'list_id'].nil?

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
        :return_type => 'Array<User>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UsersApi#get_users\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Get users from a list
    # 
    # @param list_id List id
    # @param [Hash] opts the optional parameters
    # @return [Array<User>]
    def get_users_from_list(list_id, opts = {})
      data, _status_code, _headers = get_users_from_list_with_http_info(list_id, opts)
      return data
    end

    # Get users from a list
    # 
    # @param list_id List id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Array<User>, Fixnum, Hash)>] Array<User> data, response status code and response headers
    def get_users_from_list_with_http_info(list_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: UsersApi.get_users_from_list ..."
      end
      # verify the required parameter 'list_id' is set
      if @api_client.config.client_side_validation && list_id.nil?
        fail ArgumentError, "Missing the required parameter 'list_id' when calling UsersApi.get_users_from_list"
      end
      # resource path
      local_var_path = "/public-api/lists/{listId}/users".sub('{' + 'listId' + '}', list_id.to_s)

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
        :return_type => 'Array<User>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UsersApi#get_users_from_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
