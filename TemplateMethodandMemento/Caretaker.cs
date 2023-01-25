using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandMemento
{
    class Caretaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void BackUp()
        {
            this._mementos.Add(this._originator.Save());
            if(this._mementos.Count > 1)
            {
                Form1._Form1.buttonUndo.Enabled = true; 
            }
        }

        public object GetCurrentState()
        {
            var memento = this._mementos.Last();
            return memento.GetState();
        }

        public object Undo()
        {
            if (this._mementos.Count <= 1)
            {
                Form1._Form1.buttonUndo.Enabled = false;
                return null;
            }
            else
            {
                var memento = this._mementos.Last();
                this._mementos.Remove(memento);
                return memento.GetState();
            }
        }
        public void ClearUnnecessaryHistory()
        {
            while (this._mementos.Count > 0)
            {
                this._mementos.Remove(this._mementos.Last());
            }
            Form1._Form1.buttonUndo.Enabled = false;
            return;
        }
    }
}
