using System;
using System.Collections.Generic;
using System.Text;

namespace AwsSamplesNetcore.S3.Crud.ConsoleApp
{
    public class FileS3
    {
        public FileS3(string name, string body)
        {
            this.Name = name;
            this.Body = body;
        }

        public string Name { get; }
        public string Body { get; }
    }
}
