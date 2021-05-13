using System;
using System.Collections.Generic;
using System.Text;

namespace AwsDotnetCsharp
{
    public class ResultProcess
    {
        public ResultProcess(bool finished)
        {
            Finished = finished;
        }

        public bool Finished { get; set; }

    }
}
