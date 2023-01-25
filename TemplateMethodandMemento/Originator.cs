using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandMemento
{
    class Originator
    {
        private object _state;

        public Originator(object state)
        {
            this._state = state;
        }

        public void DoSomeThing(object state_change)
        {
            this._state = state_change;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this._state);
        }
    }
}
