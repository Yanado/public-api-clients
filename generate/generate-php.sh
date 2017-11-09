#!/usr/bin/env bash
java -jar swagger-codegen-cli.jar generate \
-i https://api.yanado.com/v2/swagger.json \
-l php  \
-o yanado-api-php \
--model-package=com.yanado.model \
--api-package=com.yanado.api \
--invoker-package=com.yanado.invoker