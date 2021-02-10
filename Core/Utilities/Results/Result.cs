using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    public class Result : IResult
    {
        public Result(bool success,string message) : this(success)
        {
            Message = message;
                    }

        public Result(bool success)  //necessary do this
        {
            
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; } //get -readonly can set on constructor
    }
}
