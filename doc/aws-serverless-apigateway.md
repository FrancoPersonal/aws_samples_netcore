
sls create --template aws-csharp --path awssamplesnetcore-serverless-apigateway
dotnet add package LocalStack.Client


awslocal lambda invoke --function-name hello response.json
awslocal lambda invoke --function-name awssamplesneycore-serverless-basic-local-hello response.json

sls invoke -f hello