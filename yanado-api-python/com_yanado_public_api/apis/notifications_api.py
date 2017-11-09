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


class NotificationsApi(object):
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

    def get_notifications(self, type, **kwargs):
        """
        Get notifications
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_notifications(type, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str type: Notification type (required)
        :param bool any_user: Any user
        :param str list_id: List id
        :return: list[Notification]
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('callback'):
            return self.get_notifications_with_http_info(type, **kwargs)
        else:
            (data) = self.get_notifications_with_http_info(type, **kwargs)
            return data

    def get_notifications_with_http_info(self, type, **kwargs):
        """
        Get notifications
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please define a `callback` function
        to be invoked when receiving the response.
        >>> def callback_function(response):
        >>>     pprint(response)
        >>>
        >>> thread = api.get_notifications_with_http_info(type, callback=callback_function)

        :param callback function: The callback function
            for asynchronous request. (optional)
        :param str type: Notification type (required)
        :param bool any_user: Any user
        :param str list_id: List id
        :return: list[Notification]
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['type', 'any_user', 'list_id']
        all_params.append('callback')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method get_notifications" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'type' is set
        if ('type' not in params) or (params['type'] is None):
            raise ValueError("Missing the required parameter `type` when calling `get_notifications`")


        collection_formats = {}

        path_params = {}
        if 'type' in params:
            path_params['type'] = params['type']

        query_params = []
        if 'any_user' in params:
            query_params.append(('anyUser', params['any_user']))
        if 'list_id' in params:
            query_params.append(('listId', params['list_id']))

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

        return self.api_client.call_api('/public-api/notifications/{type}', 'GET',
                                        path_params,
                                        query_params,
                                        header_params,
                                        body=body_params,
                                        post_params=form_params,
                                        files=local_var_files,
                                        response_type='list[Notification]',
                                        auth_settings=auth_settings,
                                        callback=params.get('callback'),
                                        _return_http_data_only=params.get('_return_http_data_only'),
                                        _preload_content=params.get('_preload_content', True),
                                        _request_timeout=params.get('_request_timeout'),
                                        collection_formats=collection_formats)
