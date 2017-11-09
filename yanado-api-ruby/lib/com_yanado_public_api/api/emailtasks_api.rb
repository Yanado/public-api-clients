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
  class EmailtasksApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end

    # Get tasks with emails attached
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :list_id List id
    # @option opts [String] :assignee Assignee
    # @option opts [String] :status_id Status Id
    # @option opts [String] :query Query
    # @return [Array<EmailTask>]
    def get_email_tasks(opts = {})
      data, _status_code, _headers = get_email_tasks_with_http_info(opts)
      return data
    end

    # Get tasks with emails attached
    # 
    # @param [Hash] opts the optional parameters
    # @option opts [String] :list_id List id
    # @option opts [String] :assignee Assignee
    # @option opts [String] :status_id Status Id
    # @option opts [String] :query Query
    # @return [Array<(Array<EmailTask>, Fixnum, Hash)>] Array<EmailTask> data, response status code and response headers
    def get_email_tasks_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug "Calling API: EmailtasksApi.get_email_tasks ..."
      end
      # resource path
      local_var_path = "/public-api/email-tasks"

      # query parameters
      query_params = {}
      query_params[:'listId'] = opts[:'list_id'] if !opts[:'list_id'].nil?
      query_params[:'assignee'] = opts[:'assignee'] if !opts[:'assignee'].nil?
      query_params[:'statusId'] = opts[:'status_id'] if !opts[:'status_id'].nil?
      query_params[:'query'] = opts[:'query'] if !opts[:'query'].nil?

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
        :return_type => 'Array<EmailTask>')
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: EmailtasksApi#get_email_tasks\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
