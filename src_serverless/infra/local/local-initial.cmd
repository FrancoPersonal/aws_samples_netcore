cd ../../%appFolder%
call ren "serverless.yml" "serverless-original.yml"
call ren "serverless-localstack.yml" "serverless.yml"
cd ../infra/local