using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.Observer
{
    public class SecretariaListener : ListenerTelefone
    {
        public void TocouTelefone(string mensagem)
        {
            Console.WriteLine("Secretária: Bem vindo!");
        }
    }
}
