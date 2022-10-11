using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.ProxyMethod
{
    public interface DatabaseOperations
    {
        void Save();
        void Delete();
        void Search();
        void Update();
    }
}
