# Yanado Public SDKs

In this repository you can find generated SDKs for several languages: java, php, python, javascript, ruby. 

Yanado public API follows OpenAPI specification and it generated with [Swagger](https://api.yanado.com/public-api-swagger-ui/). Swagger allows developers generate their own clients (SDKs) for desired programming languages. 

Click on the following link to read public API documentation: [Yanado API Documentation](https://api.yanado.com/public-api-slate/)

You can generate client libraries with swagger-codegen in more then 20 programming languages. Here is a list of languages supported at the moment:

```
akka-scala, android, apache2, apex, aspnet5, aspnetcore, async-scala, bash, csharp, clojure, cwiki, cpprest, CsharpDotNet2, dart, elixir, eiffel, erlang-server, finch, flash, python-flask, go, go-server, groovy, haskell, jmeter, jaxrs-cxf-client, jaxrs-cxf, java, inflector, jaxrs-cxf-cdi, jaxrs-spec, jaxrs, msf4j, java-play-framework, jaxrs-resteasy-eap, jaxrs-resteasy, javascript, javascript-closure-angular, java-vertx, kotlin, lumen, nancyfx, nodejs-server, objc, perl, php, php-symfony, powershell, pistache-server, python, qt5cpp, rails5, restbed, ruby, scala, scalatra, silex-PHP, sinatra, slim, spring, dynamic-html, html2, html, swagger, swagger-yaml, swift4, swift3, swift, tizen, typescript-angular2, typescript-angular, typescript-fetch, typescript-jquery, typescript-node, undertow, ze-ph
```

This mono-repository already holds 4 client libraries and scripts using which we have generated them. We encourage you to help us extend this list by adding a new scripts into the generate folder.

Lets see how to generate java client library (this script can be found in folder generate within this repository):

```
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
```

Generating other SDKs is similar, only parameters differ. For example, python codegen command would be : 
```
java -jar swagger-codegen-cli.jar generate \
-i https://api.yanado.com/v2/swagger.json \
-l python  \
-o yanado-api-python \
-DpackageName=com_yanado_public_api \
-DprojectName=yanado-public-api
-DpackageUrl=com.yanado
```

The result of swagger-coden generating process is located in folders yanado-api-java, yanado-api-python etc. There you can see that client library is generated along with documentation with code examples for every operation. 

Codegen is an open source project that can be found [here](https://github.com/swagger-api/swagger-codegen) along with detailed documentation.

Codegen requirements are
* Java ( 7 runtime is minimum) installed or you can use Docker as well.
* swagger-codegen-cli.jar located on your machine.


### Quickstart:
Download latest swagger-codegen-cli.jar and execute the help command or use commands above.

```
wget http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar -O swagger-codegen-cli.jar

java -jar swagger-codegen-cli.jar help
```

### Show all languages

```
java -jar swagger-codegen-cli.jar  langs
```

### Show language specificic help (e.g. ruby)
```
java -jar swagger-codegen-cli.jar  config-help -l ruby

````

If you have any problems or questions do not hesitate to contact us. 
