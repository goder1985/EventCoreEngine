using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCore.Events
{
    public class DistributeEventResult
    {
        private IEvent _event;
        public IEvent Event
        {
            get { return _event; }
            set { _event = value; }
        }        

        private List<EventResult> _eventResult;
        public  List<EventResult>EventResult
        {
            get { return _eventResult; }           
        }

        public DistributeEventResult(IEvent _event)
        {
            this._event = _event;
            if (_event.HaveResult)
            {
                _eventResult = new List<EventResult>();
            }
        }

        public void AddEventResult(EventResult eventresult)
        {
            if (_event.HaveResult)
            {
                if (_eventResult != null)
                {
                   
                        _eventResult.Add(eventresult);
                   
                    
                }
            }
        }

    }
}
