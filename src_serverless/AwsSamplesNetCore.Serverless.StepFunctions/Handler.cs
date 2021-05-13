using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace AwsDotnetCsharp
{
    /// <summary>
    /// Defines the <see cref="Handler" />.
    /// </summary>
    public class Handler
    {
        /// <summary>
        /// The Hello.
        /// </summary>
        /// <param name="request">The request<see cref="Request"/>.</param>
        /// <returns>The <see cref="Response"/>.</returns>
        public Response Hello(Request request)
        {
            return new Response("Go Serverless v1.0! Your function executed successfully!", request, new ResultProcess(true));
        }

        /// <summary>
        /// The StartTimer.
        /// </summary>
        /// <param name="request">The request<see cref="Request"/>.</param>
        /// <returns>The <see cref="Response"/>.</returns>
        public Response StartTimer(Request request)
        {
            return new Response("StartTimer Go Serverless v1.0! Your function executed successfully!", request, new ResultProcess(true));
        }
    }

   

}
