using EventCore.Events.EventsArgs;
using System;
using System.Linq;

namespace EventCore.Events.DefaultEvents
{
      
   public abstract class BaseEvent:IEvent
    {
        private HandlerEvent _handler;
        private string _eventName;
        private bool _startInThread=false;
        public bool HaveResult
        {
            get { return true; }
        }

        public bool StartInThread
        {
            get { return _startInThread; }
        }

        public HandlerEvent EventHandler
        {
            get {return _handler;}
        }


        public BaseEvent(string NameEvent,bool AsyncEvent=false)
        {
            _eventName = NameEvent;
            _startInThread = AsyncEvent;
        }

        public DistributeEventResult distributeEvent(object sender, EEventArgs args)
        {

            if (_handler != null)
            {
                Delegate[] inv = _handler.GetInvocationList();
                DistributeEventResult er = new DistributeEventResult(this);
                     for (int i = 0; i < inv.Length; i++)
                {
                    HandlerEvent he = (HandlerEvent)inv[i];
                    if (_startInThread)
                    {
                        he.BeginInvoke(sender, args, CompliteEventDistribute, he);
                    }
                    else
                    {

                        er.AddEventResult(he.Invoke(sender, args));
                    }
                }
                     return er;
            }
           
            
            return null;
        }

        private void CompliteEventDistribute(IAsyncResult ar)
        {
            if (ar == null) throw new ArgumentNullException("ar");

            HandlerEvent bo = ar.AsyncState as HandlerEvent;
           // Trace.Assert(bo != null, "Неверный тип объекта");
            EventResult result = bo.EndInvoke(ar);
        }

        public EventStatus SubScrible(HandlerEvent handler)
        {
            if (_handler == null)
            {
                _handler = _handler + handler;
                return new EventStatus(EnumStatusEvent.Sucsess, "Handle " + handler.Method+ " SubScrible");
            }
            else
            {


                Delegate[] inv = _handler.GetInvocationList();

                if (!inv.Contains(handler))
                {
                    _handler = _handler + handler;
                    return new EventStatus(EnumStatusEvent.Sucsess,"Handle "+handler.Method+" SubScrible");
                }
                else
                {
                    return new EventStatus(EnumStatusEvent.AlreadyHandleSubScrible, "This handle already SubScrible");
                }
            }

        }

        public EventStatus UnSubScrible(HandlerEvent handler)
        {
            if (_handler == null)
            {
               // _handler = _handler + _handler;
                return new EventStatus(EnumStatusEvent.Sucsess, "Handle " + handler.Method + " UnSubScrible");
            }
            else
            {
                Delegate[] inv = _handler.GetInvocationList();
                if (!inv.Contains(handler))
                {

                    return new EventStatus(EnumStatusEvent.HandleNotSubScrible, "This handle not SubScrible");
                }
                else
                {
                    _handler = _handler - handler;
                    return new EventStatus(EnumStatusEvent.Sucsess, "Handle " + handler.Method + " UnSubScrible");
                }
            }
        }

        public string EventName
        {
            get { return _eventName; }
        }
        public static string EVENTNAME
        {
            get { return "name"; }
        }

       
    }
}
