using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCore.Events
{
    public class EventResult
    {
        public string Result = "";
        public object obj;
        public EventResult(object obj,string res)
        {
            this.obj = obj;
            this.Result = res;
        }
    }
}
