using EventCore.Components;
using EventCore.Events;
using EventCore.Events.DefaultEvents;
using EventCore.Events.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventCore
{
    public class ECore : IDisposable
    {

        #region Private field
        private readonly EventBus _eventBus = EventBus.INSTANCE;
        private readonly ComponentManager _componentManager = ComponentManager.INSTANCE;
        private bool _isRun;
        private Thread _mainThread;        
        #endregion
        #region Propertes field
        public EventBus EVENTBUS
        {
            get
            {
                return _eventBus;
            }
        }
        public ComponentManager COMPONENTMANAGER
        {
            get
            {
                return _componentManager;
            }
        }
        public bool IsRun
        {
            get { return _isRun; }
        }
        #endregion


        public ECore()
        {


        }

        public void run()
        {
            _isRun = true;
            _eventBus.distributeEvent("StartEvent", this, new EEventArgs());
            Init();
            RunLoop();


        }
        public void Stop()
        {
            EndLoop();
        }
        private void PreInitialize()
        {
            
            
        }
        private void Initialize()
        {
            _eventBus.distributeEvent("InitializeEvent", this, new EEventArgs());
            
        }
        private void PostInitialize()
        {
        }
        private void Init()
        {
            PreInitialize();
            Initialize();
            PostInitialize();

        }

        private void RunLoop()
        {
            _mainThread = new Thread(new ThreadStart(Loop));
            _mainThread.Start();
        }
        private void EndLoop()
        {
            _isRun = false;
            Thread.Sleep(2000);
            _mainThread.Abort();
            _mainThread = null;
        }

        private void Loop()
        {
            while (_isRun)
            {
                StartTick();
                Tick();
                EndTick();
            }
        }

        private void StartTick()
        {
            _eventBus.distributeEvent("PreTickEvent", this, new EEventArgs()); 
        }        
        private void Tick()
        {
            _eventBus.distributeEvent("TickEvent", this, new EEventArgs());
        }
        private void EndTick()
        {
            _eventBus.distributeEvent("PostTickEvent", this, new EEventArgs());
        }
        

        public void Dispose()
        {

        }
    }
}
