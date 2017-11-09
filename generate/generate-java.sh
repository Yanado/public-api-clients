#!/usr/bin/env bash
java -jar swagger-codegen-cli.jar generate \
  -i https://api.yanado.com/v2/swagger.json -l java \
  -o yanado-api-java \
  --model-package=com.yanado.model \
  --api-package=com.yanado.api \
  --invoker-package=com.yanado.invoker \
  --group-id=com.yanado \
  --artifact-id=public-api \
  --artifact-version=0.1 \
  -DdateLibrary=java8 \
  -Djava8=true \
  --library=okhttp-gson \
  -DdeveloperName=Savic\ Prvoslav \
  -DdeveloperEmail=prle@yanado.com \
  -DdeveloperOrganization=Yanado \
  -DdeveloperOrganizationUrl=https://yanado.com \
  -Dlicence-url=http://yanado.com/licence \
  -DlicenceName=Yanado\ Licence

