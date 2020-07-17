using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AwsSamplesNetcore.S3.Wapper
{
    public class S3wapper
    {
        IAmazonS3 client;
        public S3wapper(IAmazonS3 client)
        {
            this.client = client;
        }

        public async Task<IEnumerable<string>> ListBucketsAsync()
        {
            var buckets = await client.ListBucketsAsync();
            return buckets.Buckets.Select(b => b.BucketName);
        }
        public async Task<HttpStatusCode> PutBucketAsync(string bucketName)
        {
            var response = await client.PutBucketAsync(bucketName);
            return response.HttpStatusCode;
        }


        public async Task<IEnumerable<string>> ListObjectsAsync(string bucketName)
        {
            ListObjectsResponse objs = await client.ListObjectsAsync(bucketName);
            return objs.S3Objects.Select(b => b.Key);
        }

        public async Task<HttpStatusCode> DeleteObjectAsync(string bucketName, string key)
        {
            var objs = await client.DeleteObjectAsync(bucketName, key);
            return objs.HttpStatusCode;
        }


        public async Task<HttpStatusCode> PutObjectAsync(string bucketName, string fileName,string ContentBody)
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = fileName,
                ContentBody = ContentBody
            };

            var objs = await client.PutObjectAsync(request);
            return objs.HttpStatusCode;
        }

        public async Task<HttpStatusCode> DeleteObjectsAsync(string bucketName, IEnumerable<string> keys)
        {
            DeleteObjectsRequest request = new DeleteObjectsRequest()
            {
                BucketName = bucketName,
                Quiet = true,
                Objects = keys.Select(k => new KeyVersion() { Key = k }).ToList()
            };

            var objs = await client.DeleteObjectsAsync(request);
            return objs.HttpStatusCode;
        }

    }
}
