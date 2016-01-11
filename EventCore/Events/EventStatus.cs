using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCore.Events
{
    public class EventStatus
    {
        private EnumStatusEvent _eventError;
        public EnumStatusEvent EnumError
        { get { return _eventError; } }
        private string _errormsg;

        public string ErrorMessage
        {
            get { return _errormsg; }           
        }
        
        public EventStatus(EnumStatusEvent eventError=EnumStatusEvent.None,string errormsg="")
        {
            // TODO: Complete member initialization
            this._eventError = eventError;
            this._errormsg = errormsg;
        }
    }
}
