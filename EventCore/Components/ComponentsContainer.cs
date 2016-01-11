using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCore.Components
{
    class ComponentsContainer:IContainer
    {

        Dictionary<int, IComponent> _container;

        public void Add(IComponent component, string name)
        {
            
            throw new NotImplementedException();
        }

        public void Add(IComponent component)
        {
            throw new NotImplementedException();
        }

        private void Resort()
        {
            _container.OrderBy(id => id.Key);
        }

        public ComponentCollection Components
        {
            get { throw new NotImplementedException(); }
        }

        public void Remove(IComponent component)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
