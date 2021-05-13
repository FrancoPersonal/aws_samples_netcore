cd ../../%appFolder%
ren "serverless.yml" "serverless-original.yml"
ren "serverless-localstack.yml" "serverless.yml"
cd ../infra/local