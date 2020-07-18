using AwsSamplesNetcore.S3.Wapper;
using AwsSamplesNetcore.TestUtils;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Tools.Configuration;

namespace DeleteS3ByPrefix.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigurationManager configManager = new ConfigurationManager();

            IConfiguration config = configManager.BuildConfig();
            
            var listobjects = config.GetSection("filesToDelete").Get<string[]>();

            Console.WriteLine("Hello World!");
            string bucketname = config.GetSection("bucketname").Get<string>(); 
          //  List<string> listobjects = new List<string>() { "fileNameTest1.txt", "fileNameTest2.txt", "fileNameTest3.txt" };


            var filenames =JsonConvert.SerializeObject(listobjects);

            S3wapper wapper = new S3wapper(AwsLocalBuilder.LocalS3Credentials());            
            if (listobjects.Any())
            {
                Console.WriteLine(JsonConvert.SerializeObject(listobjects));
                var result = wapper.DeleteObjectsAsync(bucketname, listobjects).Result;
                Console.WriteLine($"all file deleted {result}");
            }
            Console.ReadKey();

        }
    }
}
