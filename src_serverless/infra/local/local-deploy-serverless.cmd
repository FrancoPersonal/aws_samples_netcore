call local-configure-environment.cmd || goto :error
call local-initial.cmd || goto :error
echo "Building and packaging lambda..."
call local-build.cmd || goto :error
call local-serverless-test.cmd || goto :error
::call local-serverless-app.cmd || goto :error
::sls deploy --stage local
call local-clean.cmd :error
@echo off
goto :eof

:error
echo on
call local-clean.cmd
echo Failed with error %errorlevel%.
goto :eof