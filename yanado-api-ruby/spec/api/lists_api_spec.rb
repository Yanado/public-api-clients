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

# Unit tests for ComYanadoPublicApi::ListsApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'ListsApi' do
  before do
    # run before each test
    @instance = ComYanadoPublicApi::ListsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ListsApi' do
    it 'should create an instance of ListsApi' do
      expect(@instance).to be_instance_of(ComYanadoPublicApi::ListsApi)
    end
  end

  # unit tests for get_lists
  # Get lists
  # 
  # @param [Hash] opts the optional parameters
  # @return [Array<Array>]
  describe 'get_lists test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end