#!/usr/bin/env bash
java -jar swagger-codegen-cli.jar generate  \
-i https://api.yanado.com/v2/swagger.json \
-l CsharpDotNet2  \
-o yanado-api-c-sharp