=begin
#Yanado REST API

#REST API for Yanado

OpenAPI spec version: 1.0
Contact: prle@yanado.com
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 2.2.3

=end

require 'date'

module ComYanadoPublicApi

  class Notification
    # Task assignee id
    attr_accessor :assignee_id

    # Task assignee name
    attr_accessor :assignee_name

    # Created
    attr_accessor :created

    # Id
    attr_accessor :id

    # Task list id
    attr_accessor :list_id

    # Task list name
    attr_accessor :list_name

    # Task status id
    attr_accessor :status_id

    # Task status name
    attr_accessor :status_name

    # Task created
    attr_accessor :task_created

    # Task description
    attr_accessor :task_description

    # Task due date
    attr_accessor :task_due_date

    # Task high priority
    attr_accessor :task_high_priority

    # Task id
    attr_accessor :task_id

    # Task Name
    attr_accessor :task_name

    # User id
    attr_accessor :user_id

    # User name
    attr_accessor :user_name


    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'assignee_id' => :'assigneeId',
        :'assignee_name' => :'assigneeName',
        :'created' => :'created',
        :'id' => :'id',
        :'list_id' => :'listId',
        :'list_name' => :'listName',
        :'status_id' => :'statusId',
        :'status_name' => :'statusName',
        :'task_created' => :'taskCreated',
        :'task_description' => :'taskDescription',
        :'task_due_date' => :'taskDueDate',
        :'task_high_priority' => :'taskHighPriority',
        :'task_id' => :'taskId',
        :'task_name' => :'taskName',
        :'user_id' => :'userId',
        :'user_name' => :'userName'
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'assignee_id' => :'String',
        :'assignee_name' => :'String',
        :'created' => :'DateTime',
        :'id' => :'Integer',
        :'list_id' => :'String',
        :'list_name' => :'String',
        :'status_id' => :'String',
        :'status_name' => :'String',
        :'task_created' => :'DateTime',
        :'task_description' => :'String',
        :'task_due_date' => :'DateTime',
        :'task_high_priority' => :'BOOLEAN',
        :'task_id' => :'String',
        :'task_name' => :'String',
        :'user_id' => :'String',
        :'user_name' => :'String'
      }
    end

    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.each_with_object({}){|(k,v), h| h[k.to_sym] = v}

      if attributes.has_key?(:'assigneeId')
        self.assignee_id = attributes[:'assigneeId']
      end

      if attributes.has_key?(:'assigneeName')
        self.assignee_name = attributes[:'assigneeName']
      end

      if attributes.has_key?(:'created')
        self.created = attributes[:'created']
      end

      if attributes.has_key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.has_key?(:'listId')
        self.list_id = attributes[:'listId']
      end

      if attributes.has_key?(:'listName')
        self.list_name = attributes[:'listName']
      end

      if attributes.has_key?(:'statusId')
        self.status_id = attributes[:'statusId']
      end

      if attributes.has_key?(:'statusName')
        self.status_name = attributes[:'statusName']
      end

      if attributes.has_key?(:'taskCreated')
        self.task_created = attributes[:'taskCreated']
      end

      if attributes.has_key?(:'taskDescription')
        self.task_description = attributes[:'taskDescription']
      end

      if attributes.has_key?(:'taskDueDate')
        self.task_due_date = attributes[:'taskDueDate']
      end

      if attributes.has_key?(:'taskHighPriority')
        self.task_high_priority = attributes[:'taskHighPriority']
      end

      if attributes.has_key?(:'taskId')
        self.task_id = attributes[:'taskId']
      end

      if attributes.has_key?(:'taskName')
        self.task_name = attributes[:'taskName']
      end

      if attributes.has_key?(:'userId')
        self.user_id = attributes[:'userId']
      end

      if attributes.has_key?(:'userName')
        self.user_name = attributes[:'userName']
      end

    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properies with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      return invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          assignee_id == o.assignee_id &&
          assignee_name == o.assignee_name &&
          created == o.created &&
          id == o.id &&
          list_id == o.list_id &&
          list_name == o.list_name &&
          status_id == o.status_id &&
          status_name == o.status_name &&
          task_created == o.task_created &&
          task_description == o.task_description &&
          task_due_date == o.task_due_date &&
          task_high_priority == o.task_high_priority &&
          task_id == o.task_id &&
          task_name == o.task_name &&
          user_id == o.user_id &&
          user_name == o.user_name
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Fixnum] Hash code
    def hash
      [assignee_id, assignee_name, created, id, list_id, list_name, status_id, status_name, task_created, task_description, task_due_date, task_high_priority, task_id, task_name, user_id, user_name].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.swagger_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map{ |v| _deserialize($1, v) } )
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        end # or else data not found in attributes(hash), not an issue as the data can be optional
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :BOOLEAN
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        temp_model = ComYanadoPublicApi.const_get(type).new
        temp_model.build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        next if value.nil?
        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map{ |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end

  end

end
