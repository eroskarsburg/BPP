using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Observer
{
    public class Telefone
    {
        ManagementListenerTelefone management = new ManagementListenerTelefone();

        public string mensagem { get { return mensagem; } set { management.TocouTelefone(value); } }

        public void AdicionarListener(ListenerTelefone listenerTelefone)
        {
            this.management.AddListener(listenerTelefone);
        }
    }
}
