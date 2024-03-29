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

# Unit tests for ComYanadoPublicApi::TasksApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'TasksApi' do
  before do
    # run before each test
    @instance = ComYanadoPublicApi::TasksApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of TasksApi' do
    it 'should create an instance of TasksApi' do
      expect(@instance).to be_instance_of(ComYanadoPublicApi::TasksApi)
    end
  end

  # unit tests for create_task
  # Create task
  # 
  # @param [Hash] opts the optional parameters
  # @option opts [RequestTask] :task_request Body
  # @return [Task]
  describe 'create_task test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_task
  # Get task
  # 
  # @param task_id Task id
  # @param [Hash] opts the optional parameters
  # @return [Task]
  describe 'get_task test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_tasks
  # Get tasks
  # 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :list_id List id
  # @option opts [String] :assignee Assignee
  # @option opts [String] :status_id Status Id
  # @option opts [String] :query Query
  # @return [Array<Task>]
  describe 'get_tasks test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for update_task
  # Update task
  # 
  # @param task_id Task id
  # @param [Hash] opts the optional parameters
  # @option opts [UpdateRequestTask] :task_request Body
  # @return [Task]
  describe 'update_task test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
