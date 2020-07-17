using Amazon.Runtime;
using Amazon.S3;
using Newtonsoft.Json;
using System;
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
            // const string bucketname = "test-bucket";
            const string fileNameTest = "fileNameTest.txt";
            const string fileContent = "sample file contemt";
            S3wapper wapper = new S3wapper(AwsLocalBuilder.LocalS3Credentials());
            var listbuckets = wapper.ListBucketsAsync().Result.ToList();
            listbuckets
                .ForEach(async b =>
                {
                    Console.WriteLine(b);
                    await wapper.PutObjectAsync(b, fileNameTest, fileContent);
                    Console.WriteLine($"upload file {fileNameTest}");
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
