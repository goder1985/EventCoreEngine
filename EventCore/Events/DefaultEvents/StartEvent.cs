using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Events.DefaultEvents
{
    public class StartEvent : BaseEvent
    {

        public StartEvent()
            : base("StartEvent")
        {

        }
    }
}
