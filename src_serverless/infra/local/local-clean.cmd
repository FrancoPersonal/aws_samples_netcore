cd ../../%appFolder%
call ren "serverless.yml" "serverless-localstack.yml"
call ren "serverless-original.yml" "serverless.yml"
cd ../infra/local