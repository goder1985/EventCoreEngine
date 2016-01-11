using EventCore.Events.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCore.Events
{

    public interface IEvent
    {
        
        bool HaveResult { get; }
        bool StartInThread { get; }
        string EventName { get; }
        HandlerEvent EventHandler { get; }
        DistributeEventResult distributeEvent(dynamic sender,EEventArgs args);
        EventStatus SubScrible(HandlerEvent handler);
        EventStatus UnSubScrible(HandlerEvent handler);
    }
}
