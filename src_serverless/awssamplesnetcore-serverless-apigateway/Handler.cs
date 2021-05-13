using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;


namespace AwsDotnetCsharp
{
    public class Handler
    {
        private readonly IJsonConverter _jsonConverter;
        public Handler() : this(null)
        {
        }

        public Handler(IJsonConverter jsonConverter)
        {
            _jsonConverter = jsonConverter ?? new JsonConverter();
        }

        //public APIGatewayProxyResponse Hello(APIGatewayProxyRequest request, ILambdaContext context)
        //{
        //    context.Logger.LogLine($"Query request: {_jsonConverter.SerializeObject(request)}");


        //    var requestBody = request?.Body == null ? new Request("1", "2", "3")
        //        : _jsonConverter.DeserializeObject<Request>(request?.Body);

        //    return new APIGatewayProxyResponse
        //    {
        //        StatusCode = (int)HttpStatusCode.OK,
        //        Body = _jsonConverter.SerializeObject(new Response("Go Serverless v1.0! Your function executed successfully!", requestBody))
        //    };
        //}

        public async Task<APIGatewayProxyResponse> Hello(APIGatewayProxyRequest request, ILambdaContext context)
        {
            var result = await Task.Run(() => { return "Hello Get"; });

            return new APIGatewayProxyResponse { StatusCode = 200, Body = JsonConvert.SerializeObject(result) };
        }


    }

    public class Response
    {
      public string Message {get; set;}
      public Request Request {get; set;}

      public Response(string message, Request request){
        Message = message;
        Request = request;
      }
    }

    public class Request
    {
      public string Key1 {get; set;}
      public string Key2 {get; set;}
      public string Key3 {get; set;}

      public Request(string key1, string key2, string key3){
        Key1 = key1;
        Key2 = key2;
        Key3 = key3;
      }
    }
}
