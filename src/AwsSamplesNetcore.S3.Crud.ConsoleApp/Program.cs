using Amazon.Runtime;
using Amazon.S3;
using AwsSamplesNetcore.S3.Wapper;
using AwsSamplesNetcore.TestUtils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AwsSamplesNetcore.S3.Crud.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            const string bucketname = "test-bucket";

            List<FileS3> Files = new List<FileS3>()
            {
                new FileS3("fileNameTest.txt","sample file content 1"),
                new FileS3("fileNameTest1.txt","sample file content 2"),
                new FileS3("fileNameTest2.txt","sample file content 3"),
                new FileS3("fileNameTest3.txt","sample file content 4"),
                new FileS3("fileNameTest4.txt","sample file content 5")
            };

            

            S3wapper wapper = new S3wapper(AwsLocalBuilder.LocalS3Credentials());

            var createResult=  wapper.PutBucketAsync(bucketname).Result;
            Console.WriteLine($"create bucket {bucketname} {createResult}");

            var listbuckets = wapper.ListBucketsAsync().Result.ToList();
            listbuckets
                .ForEach(async b =>
                {
                    Console.WriteLine(b);

                    Files.ForEach(async f =>
                    {
                        await wapper.PutObjectAsync(b, f.Name, f.Body);
                        Console.WriteLine($"upload file {b} {f.Name}");
                    }
                     );
                   
                    var listobjects = wapper.ListObjectsAsync(b).Result.ToList();
                    if (listobjects.Any())
                    {
                        Console.WriteLine(JsonConvert.SerializeObject(listobjects));
                        var result =await wapper.DeleteObjectsAsync(b, listobjects);
                        Console.WriteLine($"all file deleted {result}");
                    }
                });
            Console.ReadKey();
        }
    }
}
