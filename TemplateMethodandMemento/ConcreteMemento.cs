using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandMemento
{
    class ConcreteMemento : IMemento
    {
        private object _state;

        public ConcreteMemento(object state)    
        {
            this._state = state;
        }

        public object GetState()
        {
            return this._state;
        }
    }
}
