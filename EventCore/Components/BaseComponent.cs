using EventCore.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Components
{
    public  partial class BaseComponent : Component
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nameComponent;

        public string Name
        {
            get { return _nameComponent; }
            set { _nameComponent = value; }
        }
        
        public BaseComponent()
        {
            InitializeComponent();
        }

        public BaseComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public virtual void SubscribleEvent(EventBus eventBus)
        {
        }
    }
}
