using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Components
{
    public partial class TimerComponent : BaseComponent
    {
        public TimerComponent()
        {
            InitializeComponent();
            this.ID = 1;
            this.Name = "Timer";
        }

        public TimerComponent(IContainer container)
        {
            container.Add(this);
            this.ID = 1;
            this.Name = "Timer";
            InitializeComponent();
        }
        public override void SubscribleEvent(Events.EventBus eventBus)
        {
            eventBus.SubscribleEvent("StartEvent", OnStart);
            eventBus.SubscribleEvent("PreTickEvent", OnPreTick);
            eventBus.SubscribleEvent("TickEvent", OnTick);
            eventBus.SubscribleEvent("PostTickEvent", OnPostTick);
            base.SubscribleEvent(eventBus);
        }

        private Events.EventResult OnPostTick(object sender, Events.EventsArgs.EEventArgs args)
        {
            return new Events.EventResult(this, "Post tick");
        }

        private Events.EventResult OnTick(object sender, Events.EventsArgs.EEventArgs args)
        {
            //Console.WriteLine("Tick event");
            return new Events.EventResult(this, "tick");
        }

        private Events.EventResult OnPreTick(object sender, Events.EventsArgs.EEventArgs args)
        {
            return new Events.EventResult(this, "Pre tick");
        }

        private Events.EventResult OnStart(object sender, Events.EventsArgs.EEventArgs args)
        {
            return new Events.EventResult(this, "Start");
        }
    }
}
