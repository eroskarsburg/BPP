using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Observer
{
    public class ManagementListenerTelefone
    {
        List<ListenerTelefone> listaListenerTelefones = new List<ListenerTelefone>();

        public void AddListener(ListenerTelefone listenerTelefone)
        {
            this.listaListenerTelefones.Add(listenerTelefone);
        }

        public void TocouTelefone(string mensagem)
        {
            foreach (ListenerTelefone listenerTelefone in listaListenerTelefones)
            {
                listenerTelefone.TocouTelefone(mensagem);
            }
        }
    }
}
