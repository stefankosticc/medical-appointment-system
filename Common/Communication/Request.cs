using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Communication
{
    public class Request
    {
        public Operation Operation { get; set; }
        public object Argument { get; set; }
    }
}
