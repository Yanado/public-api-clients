# coding: utf-8

"""
    Yanado REST API

    REST API for Yanado

    OpenAPI spec version: 1.0
    Contact: prle@yanado.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import os
import sys
import unittest

import com_yanado_public_api
from com_yanado_public_api.rest import ApiException
from com_yanado_public_api.apis.tasks_api import TasksApi


class TestTasksApi(unittest.TestCase):
    """ TasksApi unit test stubs """

    def setUp(self):
        self.api = com_yanado_public_api.apis.tasks_api.TasksApi()

    def tearDown(self):
        pass

    def test_create_task(self):
        """
        Test case for create_task

        Create task
        """
        pass

    def test_get_task(self):
        """
        Test case for get_task

        Get task
        """
        pass

    def test_get_tasks(self):
        """
        Test case for get_tasks

        Get tasks
        """
        pass

    def test_update_task(self):
        """
        Test case for update_task

        Update task
        """
        pass


if __name__ == '__main__':
    unittest.main()
