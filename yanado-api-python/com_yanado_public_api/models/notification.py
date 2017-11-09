# coding: utf-8

"""
    Yanado REST API

    REST API for Yanado

    OpenAPI spec version: 1.0
    Contact: prle@yanado.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class Notification(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """


    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'assignee_id': 'str',
        'assignee_name': 'str',
        'created': 'datetime',
        'id': 'int',
        'list_id': 'str',
        'list_name': 'str',
        'status_id': 'str',
        'status_name': 'str',
        'task_created': 'datetime',
        'task_description': 'str',
        'task_due_date': 'datetime',
        'task_high_priority': 'bool',
        'task_id': 'str',
        'task_name': 'str',
        'user_id': 'str',
        'user_name': 'str'
    }

    attribute_map = {
        'assignee_id': 'assigneeId',
        'assignee_name': 'assigneeName',
        'created': 'created',
        'id': 'id',
        'list_id': 'listId',
        'list_name': 'listName',
        'status_id': 'statusId',
        'status_name': 'statusName',
        'task_created': 'taskCreated',
        'task_description': 'taskDescription',
        'task_due_date': 'taskDueDate',
        'task_high_priority': 'taskHighPriority',
        'task_id': 'taskId',
        'task_name': 'taskName',
        'user_id': 'userId',
        'user_name': 'userName'
    }

    def __init__(self, assignee_id=None, assignee_name=None, created=None, id=None, list_id=None, list_name=None, status_id=None, status_name=None, task_created=None, task_description=None, task_due_date=None, task_high_priority=None, task_id=None, task_name=None, user_id=None, user_name=None):
        """
        Notification - a model defined in Swagger
        """

        self._assignee_id = None
        self._assignee_name = None
        self._created = None
        self._id = None
        self._list_id = None
        self._list_name = None
        self._status_id = None
        self._status_name = None
        self._task_created = None
        self._task_description = None
        self._task_due_date = None
        self._task_high_priority = None
        self._task_id = None
        self._task_name = None
        self._user_id = None
        self._user_name = None

        if assignee_id is not None:
          self.assignee_id = assignee_id
        if assignee_name is not None:
          self.assignee_name = assignee_name
        if created is not None:
          self.created = created
        if id is not None:
          self.id = id
        if list_id is not None:
          self.list_id = list_id
        if list_name is not None:
          self.list_name = list_name
        if status_id is not None:
          self.status_id = status_id
        if status_name is not None:
          self.status_name = status_name
        if task_created is not None:
          self.task_created = task_created
        if task_description is not None:
          self.task_description = task_description
        if task_due_date is not None:
          self.task_due_date = task_due_date
        if task_high_priority is not None:
          self.task_high_priority = task_high_priority
        if task_id is not None:
          self.task_id = task_id
        if task_name is not None:
          self.task_name = task_name
        if user_id is not None:
          self.user_id = user_id
        if user_name is not None:
          self.user_name = user_name

    @property
    def assignee_id(self):
        """
        Gets the assignee_id of this Notification.
        Task assignee id

        :return: The assignee_id of this Notification.
        :rtype: str
        """
        return self._assignee_id

    @assignee_id.setter
    def assignee_id(self, assignee_id):
        """
        Sets the assignee_id of this Notification.
        Task assignee id

        :param assignee_id: The assignee_id of this Notification.
        :type: str
        """

        self._assignee_id = assignee_id

    @property
    def assignee_name(self):
        """
        Gets the assignee_name of this Notification.
        Task assignee name

        :return: The assignee_name of this Notification.
        :rtype: str
        """
        return self._assignee_name

    @assignee_name.setter
    def assignee_name(self, assignee_name):
        """
        Sets the assignee_name of this Notification.
        Task assignee name

        :param assignee_name: The assignee_name of this Notification.
        :type: str
        """

        self._assignee_name = assignee_name

    @property
    def created(self):
        """
        Gets the created of this Notification.
        Created

        :return: The created of this Notification.
        :rtype: datetime
        """
        return self._created

    @created.setter
    def created(self, created):
        """
        Sets the created of this Notification.
        Created

        :param created: The created of this Notification.
        :type: datetime
        """

        self._created = created

    @property
    def id(self):
        """
        Gets the id of this Notification.
        Id

        :return: The id of this Notification.
        :rtype: int
        """
        return self._id

    @id.setter
    def id(self, id):
        """
        Sets the id of this Notification.
        Id

        :param id: The id of this Notification.
        :type: int
        """

        self._id = id

    @property
    def list_id(self):
        """
        Gets the list_id of this Notification.
        Task list id

        :return: The list_id of this Notification.
        :rtype: str
        """
        return self._list_id

    @list_id.setter
    def list_id(self, list_id):
        """
        Sets the list_id of this Notification.
        Task list id

        :param list_id: The list_id of this Notification.
        :type: str
        """

        self._list_id = list_id

    @property
    def list_name(self):
        """
        Gets the list_name of this Notification.
        Task list name

        :return: The list_name of this Notification.
        :rtype: str
        """
        return self._list_name

    @list_name.setter
    def list_name(self, list_name):
        """
        Sets the list_name of this Notification.
        Task list name

        :param list_name: The list_name of this Notification.
        :type: str
        """

        self._list_name = list_name

    @property
    def status_id(self):
        """
        Gets the status_id of this Notification.
        Task status id

        :return: The status_id of this Notification.
        :rtype: str
        """
        return self._status_id

    @status_id.setter
    def status_id(self, status_id):
        """
        Sets the status_id of this Notification.
        Task status id

        :param status_id: The status_id of this Notification.
        :type: str
        """

        self._status_id = status_id

    @property
    def status_name(self):
        """
        Gets the status_name of this Notification.
        Task status name

        :return: The status_name of this Notification.
        :rtype: str
        """
        return self._status_name

    @status_name.setter
    def status_name(self, status_name):
        """
        Sets the status_name of this Notification.
        Task status name

        :param status_name: The status_name of this Notification.
        :type: str
        """

        self._status_name = status_name

    @property
    def task_created(self):
        """
        Gets the task_created of this Notification.
        Task created

        :return: The task_created of this Notification.
        :rtype: datetime
        """
        return self._task_created

    @task_created.setter
    def task_created(self, task_created):
        """
        Sets the task_created of this Notification.
        Task created

        :param task_created: The task_created of this Notification.
        :type: datetime
        """

        self._task_created = task_created

    @property
    def task_description(self):
        """
        Gets the task_description of this Notification.
        Task description

        :return: The task_description of this Notification.
        :rtype: str
        """
        return self._task_description

    @task_description.setter
    def task_description(self, task_description):
        """
        Sets the task_description of this Notification.
        Task description

        :param task_description: The task_description of this Notification.
        :type: str
        """

        self._task_description = task_description

    @property
    def task_due_date(self):
        """
        Gets the task_due_date of this Notification.
        Task due date

        :return: The task_due_date of this Notification.
        :rtype: datetime
        """
        return self._task_due_date

    @task_due_date.setter
    def task_due_date(self, task_due_date):
        """
        Sets the task_due_date of this Notification.
        Task due date

        :param task_due_date: The task_due_date of this Notification.
        :type: datetime
        """

        self._task_due_date = task_due_date

    @property
    def task_high_priority(self):
        """
        Gets the task_high_priority of this Notification.
        Task high priority

        :return: The task_high_priority of this Notification.
        :rtype: bool
        """
        return self._task_high_priority

    @task_high_priority.setter
    def task_high_priority(self, task_high_priority):
        """
        Sets the task_high_priority of this Notification.
        Task high priority

        :param task_high_priority: The task_high_priority of this Notification.
        :type: bool
        """

        self._task_high_priority = task_high_priority

    @property
    def task_id(self):
        """
        Gets the task_id of this Notification.
        Task id

        :return: The task_id of this Notification.
        :rtype: str
        """
        return self._task_id

    @task_id.setter
    def task_id(self, task_id):
        """
        Sets the task_id of this Notification.
        Task id

        :param task_id: The task_id of this Notification.
        :type: str
        """

        self._task_id = task_id

    @property
    def task_name(self):
        """
        Gets the task_name of this Notification.
        Task Name

        :return: The task_name of this Notification.
        :rtype: str
        """
        return self._task_name

    @task_name.setter
    def task_name(self, task_name):
        """
        Sets the task_name of this Notification.
        Task Name

        :param task_name: The task_name of this Notification.
        :type: str
        """

        self._task_name = task_name

    @property
    def user_id(self):
        """
        Gets the user_id of this Notification.
        User id

        :return: The user_id of this Notification.
        :rtype: str
        """
        return self._user_id

    @user_id.setter
    def user_id(self, user_id):
        """
        Sets the user_id of this Notification.
        User id

        :param user_id: The user_id of this Notification.
        :type: str
        """

        self._user_id = user_id

    @property
    def user_name(self):
        """
        Gets the user_name of this Notification.
        User name

        :return: The user_name of this Notification.
        :rtype: str
        """
        return self._user_name

    @user_name.setter
    def user_name(self, user_name):
        """
        Sets the user_name of this Notification.
        User name

        :param user_name: The user_name of this Notification.
        :type: str
        """

        self._user_name = user_name

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        if not isinstance(other, Notification):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
