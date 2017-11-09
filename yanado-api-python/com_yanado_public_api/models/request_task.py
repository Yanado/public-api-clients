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


class RequestTask(object):
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
        'description': 'str',
        'due_date': 'datetime',
        'form': 'dict(str, str)',
        'list_id': 'str',
        'name': 'str',
        'status_id': 'str',
        'thread_email': 'str',
        'thread_id': 'str',
        'thread_name': 'str',
        'thread_subject': 'str'
    }

    attribute_map = {
        'assignee_id': 'assigneeId',
        'description': 'description',
        'due_date': 'dueDate',
        'form': 'form',
        'list_id': 'listId',
        'name': 'name',
        'status_id': 'statusId',
        'thread_email': 'threadEmail',
        'thread_id': 'threadId',
        'thread_name': 'threadName',
        'thread_subject': 'threadSubject'
    }

    def __init__(self, assignee_id=None, description=None, due_date=None, form=None, list_id=None, name=None, status_id=None, thread_email=None, thread_id=None, thread_name=None, thread_subject=None):
        """
        RequestTask - a model defined in Swagger
        """

        self._assignee_id = None
        self._description = None
        self._due_date = None
        self._form = None
        self._list_id = None
        self._name = None
        self._status_id = None
        self._thread_email = None
        self._thread_id = None
        self._thread_name = None
        self._thread_subject = None

        if assignee_id is not None:
          self.assignee_id = assignee_id
        if description is not None:
          self.description = description
        if due_date is not None:
          self.due_date = due_date
        if form is not None:
          self.form = form
        self.list_id = list_id
        self.name = name
        self.status_id = status_id
        if thread_email is not None:
          self.thread_email = thread_email
        if thread_id is not None:
          self.thread_id = thread_id
        if thread_name is not None:
          self.thread_name = thread_name
        if thread_subject is not None:
          self.thread_subject = thread_subject

    @property
    def assignee_id(self):
        """
        Gets the assignee_id of this RequestTask.
        Assignee id

        :return: The assignee_id of this RequestTask.
        :rtype: str
        """
        return self._assignee_id

    @assignee_id.setter
    def assignee_id(self, assignee_id):
        """
        Sets the assignee_id of this RequestTask.
        Assignee id

        :param assignee_id: The assignee_id of this RequestTask.
        :type: str
        """

        self._assignee_id = assignee_id

    @property
    def description(self):
        """
        Gets the description of this RequestTask.
        Description

        :return: The description of this RequestTask.
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """
        Sets the description of this RequestTask.
        Description

        :param description: The description of this RequestTask.
        :type: str
        """

        self._description = description

    @property
    def due_date(self):
        """
        Gets the due_date of this RequestTask.
        Due date

        :return: The due_date of this RequestTask.
        :rtype: datetime
        """
        return self._due_date

    @due_date.setter
    def due_date(self, due_date):
        """
        Sets the due_date of this RequestTask.
        Due date

        :param due_date: The due_date of this RequestTask.
        :type: datetime
        """

        self._due_date = due_date

    @property
    def form(self):
        """
        Gets the form of this RequestTask.

        :return: The form of this RequestTask.
        :rtype: dict(str, str)
        """
        return self._form

    @form.setter
    def form(self, form):
        """
        Sets the form of this RequestTask.

        :param form: The form of this RequestTask.
        :type: dict(str, str)
        """

        self._form = form

    @property
    def list_id(self):
        """
        Gets the list_id of this RequestTask.
        List id

        :return: The list_id of this RequestTask.
        :rtype: str
        """
        return self._list_id

    @list_id.setter
    def list_id(self, list_id):
        """
        Sets the list_id of this RequestTask.
        List id

        :param list_id: The list_id of this RequestTask.
        :type: str
        """
        if list_id is None:
            raise ValueError("Invalid value for `list_id`, must not be `None`")

        self._list_id = list_id

    @property
    def name(self):
        """
        Gets the name of this RequestTask.
        Name

        :return: The name of this RequestTask.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """
        Sets the name of this RequestTask.
        Name

        :param name: The name of this RequestTask.
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")

        self._name = name

    @property
    def status_id(self):
        """
        Gets the status_id of this RequestTask.
        Status Id

        :return: The status_id of this RequestTask.
        :rtype: str
        """
        return self._status_id

    @status_id.setter
    def status_id(self, status_id):
        """
        Sets the status_id of this RequestTask.
        Status Id

        :param status_id: The status_id of this RequestTask.
        :type: str
        """
        if status_id is None:
            raise ValueError("Invalid value for `status_id`, must not be `None`")

        self._status_id = status_id

    @property
    def thread_email(self):
        """
        Gets the thread_email of this RequestTask.
        Participant email

        :return: The thread_email of this RequestTask.
        :rtype: str
        """
        return self._thread_email

    @thread_email.setter
    def thread_email(self, thread_email):
        """
        Sets the thread_email of this RequestTask.
        Participant email

        :param thread_email: The thread_email of this RequestTask.
        :type: str
        """

        self._thread_email = thread_email

    @property
    def thread_id(self):
        """
        Gets the thread_id of this RequestTask.
        Thread id

        :return: The thread_id of this RequestTask.
        :rtype: str
        """
        return self._thread_id

    @thread_id.setter
    def thread_id(self, thread_id):
        """
        Sets the thread_id of this RequestTask.
        Thread id

        :param thread_id: The thread_id of this RequestTask.
        :type: str
        """

        self._thread_id = thread_id

    @property
    def thread_name(self):
        """
        Gets the thread_name of this RequestTask.
        Subject

        :return: The thread_name of this RequestTask.
        :rtype: str
        """
        return self._thread_name

    @thread_name.setter
    def thread_name(self, thread_name):
        """
        Sets the thread_name of this RequestTask.
        Subject

        :param thread_name: The thread_name of this RequestTask.
        :type: str
        """

        self._thread_name = thread_name

    @property
    def thread_subject(self):
        """
        Gets the thread_subject of this RequestTask.
        Subject

        :return: The thread_subject of this RequestTask.
        :rtype: str
        """
        return self._thread_subject

    @thread_subject.setter
    def thread_subject(self, thread_subject):
        """
        Sets the thread_subject of this RequestTask.
        Subject

        :param thread_subject: The thread_subject of this RequestTask.
        :type: str
        """

        self._thread_subject = thread_subject

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
        if not isinstance(other, RequestTask):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other