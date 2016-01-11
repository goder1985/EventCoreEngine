using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Events.DefaultEvents
{
    public class PostTickEvent : BaseEvent
    {

        public PostTickEvent()
            : base("PostTickEvent")
        {

        }
    }
}