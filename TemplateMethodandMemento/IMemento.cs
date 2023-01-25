using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodandMemento
{
    public interface IMemento
    {
        object GetState();
    }
}
