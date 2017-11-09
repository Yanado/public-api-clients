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

# Unit tests for ComYanadoPublicApi::CommentsApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CommentsApi' do
  before do
    # run before each test
    @instance = ComYanadoPublicApi::CommentsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CommentsApi' do
    it 'should create an instance of CommentsApi' do
      expect(@instance).to be_instance_of(ComYanadoPublicApi::CommentsApi)
    end
  end

  # unit tests for get_comments
  # Get comments
  # 
  # @param [Hash] opts the optional parameters
  # @option opts [String] :list_id List id
  # @option opts [String] :query Query
  # @return [Array<Comment>]
  describe 'get_comments test' do
    it "should work" do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end