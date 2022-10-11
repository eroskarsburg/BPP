using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.ProxyMethod
{
    public class DatabaseOperationImplement : DatabaseOperations
    {
        public void Delete()
        {
            Console.WriteLine("Database Deleting...");
        }

        public void Save()
        {
            Console.WriteLine("Database Saving...");
        }

        public void Search()
        {
            Console.WriteLine("Database Searching...");
        }

        public void Update()
        {
            Console.WriteLine("Database Updating...");
        }
    }
}
