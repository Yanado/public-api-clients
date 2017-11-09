#!/usr/bin/env bash
java -jar swagger-codegen-cli.jar generate \
-i https://api.yanado.com/v2/swagger.json \
-l python  \
-o yanado-api-python \
-DpackageName=com_yanado_public_api \
-DprojectName=yanado-public-api
-DpackageUrl=com.yanado