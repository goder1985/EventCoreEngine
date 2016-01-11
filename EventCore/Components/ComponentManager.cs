using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace EventCore.Components
{
    public class ComponentManager
    {
        #region static fields and method
        private static ComponentManager _instance;
        public static ComponentManager INSTANCE 
        {
            get
            {
                if (_instance == null)
                {
                    InitComponentManager();
                }
                return _instance;

            }
        }
        private static void InitComponentManager()
        {
            _instance = new ComponentManager();
            _instance.RegisterBaseComponent();
        }
        #endregion

        private Container _Components;

        public Container Components
        {
            get { return _Components; }
            set { _Components = value; }
        }
        
        

        private void RegisterBaseComponent()
        {
            new TimerComponent(_Components);
        }

        public void AddComponent(BaseComponent component)
        {
            
            _Components.Add(component,component.Name);
        }
        public void RemoveComponent(BaseComponent component)
        {

            _Components.Remove(component);
        
        }
        public BaseComponent GetComponentByName(string name)
        {
            
                
                    return (BaseComponent)_Components.Components[name];
               
            
           // return null;
        }
        public ComponentManager()
        {
            _Components = new Container();
            Console.WriteLine("Init ComponentManager");
            EventCore.Events.EventBus.INSTANCE.SubscribleEvent("InitializeEvent", Initialize);
        }

        private Events.EventResult Initialize(object sender, Events.EventsArgs.EEventArgs args)
        {
            Console.WriteLine("Init ComponentManager");
            for (int i = 0; i < _Components.Components.Count; i++)
            {
                (_Components.Components[i] as BaseComponent).SubscribleEvent(EventCore.Events.EventBus.INSTANCE);
            }
            return new Events.EventResult(this, "Initialize");
        }

       
    }
}
