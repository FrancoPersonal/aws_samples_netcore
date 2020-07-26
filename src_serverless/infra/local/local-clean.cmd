cd ../../%appFolder%
ren "serverless.yml" "serverless-localstack.yml"
ren "serverless-original.yml" "serverless.yml"
cd ../infra/local