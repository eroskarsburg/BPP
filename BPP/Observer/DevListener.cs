using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Observer
{
    public class DevListener : ListenerTelefone
    {
        public void TocouTelefone(string mensagem)
        {
            Console.WriteLine("Fala xará, é o Dev kkkkk");
        }
    }
}
