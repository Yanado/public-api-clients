=begin
#Yanado REST API

#REST API for Yanado

OpenAPI spec version: 1.0
Contact: prle@yanado.com
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.2.3

=end

require 'spec_helper'
require 'json'

# Unit tests for ComYanadoPublicApi::EmailtasksApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'EmailtasksApi' do
  before do
    # run before each test
    @instance = ComYanadoPublicApi::EmailtasksApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of EmailtasksApi' do
    it 'should create an instance of EmailtasksApi' do
      expect(@instance).to be_instance_of(ComYanadoPublicApi::EmailtasksApi)
    end
  end

  # unit tests for get_email_tasks
  # Get tasks with emails attached
  # 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :list_id List id
  # @option opts [String] :assignee Assignee
  # @option opts [String] :status_id Status Id
  # @option opts [String] :query Query
  # @return [Array<EmailTask>]
  describe 'get_email_tasks test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end