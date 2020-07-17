using Amazon.S3;
using System;
using System.Collections.Generic;
using System.Text;

namespace AwsSamplesNetcore.S3.Crud.ConsoleApp
{
    public class AwsLocalBuilder
    {
        public static IAmazonS3 LocalS3Credentials()
        {
            AmazonS3Config aWSCredentials = new AmazonS3Config()
            {
                ServiceURL = "http://localhost:4566",
                ForcePathStyle = true
            };
            return new AmazonS3Client(aWSCredentials);
        }

    }
}
