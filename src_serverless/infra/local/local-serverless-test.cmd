cd ../../%appFolder%
call npm init --yes
call npm install -g serverless-localstack
call npm install -D serverless-plugin-typescript typescript
call serverless deploy --noDeploy --stage local
cd ../infra/local