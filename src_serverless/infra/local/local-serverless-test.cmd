cd ../../%appFolder%
::call npm init -y
call npm install
call npm install --save-dev serverless-localstack
call serverless deploy --noDeploy --stage local
cd ../infra/local