using EventCore.Events.DefaultEvents;
using EventCore.Events.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Events
{
      
    public delegate EventResult  HandlerEvent(object sender, EEventArgs args);
    public class EventBus
    {
        private static EventBus _instance;

        public static EventBus INSTANCE
        {
            get 
            {
                if (_instance==null)
                {
                    InitEventBus();
                }
                return _instance; 
            }
            
        }
        
        private  bool _isInit;
        public  bool isInit { get { return _isInit; } }
        private  List<IEvent> _events = new List<IEvent>();

        public  List<IEvent> EVENTS
        {
            get { return _events; }
        }

      

        public  EventStatus SubscribleEvent(string NameEvent, HandlerEvent handler)
        {
            if (!_isInit)
            {
                RegisterBaseEvent();
            }
            IEvent found = _events.FindLast(e => e.EventName == NameEvent);
            if (found!=null)
            {
                return found.SubScrible(handler);
            }
          
            return new EventStatus(EnumStatusEvent.NotFoundEvent,"Event "+NameEvent+" not registred");

        }
        public  EventStatus UnSubscribleEvent(string NameEvent, HandlerEvent handler)
        {
            if (!_isInit)
            {
                RegisterBaseEvent();
            }
            IEvent found = _events.FindLast(e => e.EventName == NameEvent);
            if (found != null)
            {
                return found.UnSubScrible(handler);
            }

            return new EventStatus(EnumStatusEvent.NotFoundEvent, "Event " + NameEvent + " not registred");
        }
        public  bool AddEvent(IEvent _event, string eventName=null)
        {
            if (!_events.Contains(_event))
            {
                _events.Add(_event);
                return true;
            }
            else
            {
                return false;
            }
        }
        public  bool RemoveEvent(IEvent _event=null, string eventName=null)
        {
            if (_event == null && eventName!=null )
            {
                //try found by name
                if (_events.Exists(e => e.EventName == eventName))
                {
                    _events.Remove(_events.FindLast(e => e.EventName == eventName));
                }
                // not found
            }
            else if(_event!=null)
            {
                if (_events.Contains(_event))
                {
                    _events.Remove(_event);
                }
                //not found
            }
            else
            {
                //no param
            }
            return true;
        }

        public  DistributeEventResult distributeEvent(string NameEvent,object sender, EEventArgs args)
        {

            IEvent found = _events.FindLast(e => e.EventName == NameEvent);
          
            if (found != null)
            {

                return found.distributeEvent(sender,args);
            }

          //  return new EventError(EnumErrorEvent.NotFoundEvent, "Event " + NameEvent + " not registred");
            return null;
            
        }

        public static void InitEventBus()
        {
            Console.WriteLine("Init eventBus");
            _instance = new EventBus();
            _instance.RegisterBaseEvent();
        }
        public  bool RegisterBaseEvent()
        {
            if (!_isInit)
            {
                 AddEvent(new StartEvent());
                 AddEvent(new PreTickEvent());
                 AddEvent(new TickEvent());
                 AddEvent(new PostTickEvent());
                AddEvent(new InitializeEvent());
                _isInit = true;
            }
           

          
            return true;
        }
        
    }
}
