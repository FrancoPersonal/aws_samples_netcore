it is recommended have done the serverless example:
```batch
dotnet new -i "Amazon.Lambda.Templates::*"


sls create --template aws-csharp --path AwsSamplesNeyCore.Serverless.Basic
```
https://www.serverless.com/framework/docs/providers/aws/examples/hello-world/csharp/



aws lambda invoke \
    --function-name my-function