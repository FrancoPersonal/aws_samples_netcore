echo on
aws s3api create-bucket --bucket %localstackBucket% --endpoint-url=%localstackUrl%