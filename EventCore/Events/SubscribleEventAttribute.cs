using System;



namespace EventCore.Events
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public  class SubscribleEventAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string eventName;

        // This is a positional argument
        public SubscribleEventAttribute(string eventName)
        {
            this.eventName = eventName;
            
            // TODO: Implement code here
           // throw new NotImplementedException();
        }

        public string EventName
        {
            get { return eventName; }
        }

       
    }
    
}
