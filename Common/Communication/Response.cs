using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Communication
{
    public class Response
    {
        public object Data { get; set; }
        public string ExceptionMessage { get; set; }
    }
}
