using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventCore.Events
{
    public class OrderedName
    {
        public const int StartPriority = 100;
        protected int _priority;
        public int Priority { get { return _priority; } }
        private string _name;
        public string Name
        {
            get { return _name; }            
        }
        public OrderedName(string Name)
        {
            _name = Name;
        }

       
    }
}
