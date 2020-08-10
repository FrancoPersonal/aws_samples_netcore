using System;
using System.Collections.Generic;
using System.Text;

namespace AwsDotnetCsharp
{
    /// <summary>
    /// Defines the <see cref="Response" />.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        internal int Code { get; set; }

        /// <summary>
        /// Gets or sets the Message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the Request.
        /// </summary>
        public Request Request { get; set; }

        public ResultProcess Results { get; set; }
        

        /// <summary>
        /// Initializes a new instance of the <see cref="Response"/> class.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="request">The request<see cref="Request"/>.</param>
        /// <param name="code">The code<see cref="int"/>.</param>
        public Response(string message, Request request, ResultProcess results)
        {
            this.Message = message;
            this.Request = request;
            Code = request.Code;
            Results = results;
        }
    }

}
