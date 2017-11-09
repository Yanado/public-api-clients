# coding: utf-8

"""
    Yanado REST API

    REST API for Yanado

    OpenAPI spec version: 1.0
    Contact: prle@yanado.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import sys
from setuptools import setup, find_packages

NAME = "yanado-public-api"
VERSION = "1.0.0"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = ["urllib3 >= 1.15", "six >= 1.10", "certifi", "python-dateutil"]

setup(
    name=NAME,
    version=VERSION,
    description="Yanado REST API",
    author_email="prle@yanado.com",
    url="",
    keywords=["Swagger", "Yanado REST API"],
    install_requires=REQUIRES,
    packages=find_packages(),
    include_package_data=True,
    long_description="""\
    REST API for Yanado
    """
)
