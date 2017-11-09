# coding: utf-8

"""
    Yanado REST API

    REST API for Yanado

    OpenAPI spec version: 1.0
    Contact: prle@yanado.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import sys
import os
import re

# python 2 and python 3 compatibility library
from six import iteritems

from ..configuration import Configuration
from ..api_client import ApiClient


class EmailtasksApi(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        config = Configuration()
        if api_client:
            self.api_client = api_client
        else:
            if not config.api_client:
                config.api_client = ApiClient()
            self.api_client = config.api_client

    def get_email_tasks(self, **kwargs):
        """
        Get tasks with emails attached
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_email_tasks(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str list_id: List id
        :param str assignee: Assignee
        :param str status_id: Status Id
        :param str query: Query
        :return: list[EmailTask]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_email_tasks_with_http_info(**kwargs)
        else:
            (data) = self.get_email_tasks_with_http_info(**kwargs)
            return data

    def get_email_tasks_with_http_info(self, **kwargs):
        """
        Get tasks with emails attached
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_email_tasks_with_http_info(callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str list_id: List id
        :param str assignee: Assignee
        :param str status_id: Status Id
        :param str query: Query
        :return: list[EmailTask]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['list_id', 'assignee', 'status_id', 'query']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_email_tasks" % key
                )
            params[key] = val
        del params['kwargs']


        collection_formats = {}

        path_params = {}

        query_params = []
        if 'list_id' in params:
            query_params.append(('listId', params['list_id']))
        if 'assignee' in params:
            query_params.append(('assignee', params['assignee']))
        if 'status_id' in params:
            query_params.append(('statusId', params['status_id']))
        if 'query' in params:
            query_params.append(('query', params['query']))

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.\
            select_header_accept(['application/json'])

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.\
            select_header_content_type(['application/json'])

        # Authentication setting
        auth_settings = ['X-API-Key']

        return self.api_client.call_api('/public-api/email-tasks', 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='list[EmailTask]',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)
