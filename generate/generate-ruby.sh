#!/usr/bin/env bash
java -jar swagger-codegen-cli.jar generate \
-i https://api.yanado.com/v2/swagger.json \
-l ruby \
-o yanado-api-ruby \
-DgemName=com_yanado_public_api \
-DmoduleName=ComYanadoPublicApi \
-DgemVersion=0.1 \
-DgemLicence=http://yanado.com/licence \
-DgemHomepage=http://yanado.com \
-DgemSummary=Yanado\ Public\ API \
-DgemDescription=Yanado\ Public\ API \
-DgemAuthor=Savic\ Prvoslav \
-DgemAuthorEmail=prle@yanado.com