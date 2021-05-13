
sls create --template aws-csharp --path AwsSamplesNeyCore.Serverless.Basic
dotnet add package LocalStack.Client

awssamplesneycore-serverless-basic
awslocal lambda invoke --function-name hello response.json
awslocal lambda invoke --function-name awssamplesneycore-serverless-basic-local-hello response.json

sls invoke -f hello