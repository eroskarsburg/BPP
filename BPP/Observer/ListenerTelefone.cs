using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Observer
{
    public interface ListenerTelefone
    {
        // Nomenclatura LISTENER sempre será uma INTERFACE.
        void TocouTelefone(string mensagem);
    }
}
