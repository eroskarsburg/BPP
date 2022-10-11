using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPP.ProxyMethod
{
    public class DatabaseOperationProxy : DatabaseOperations
    {
        private DatabaseOperations DatabaseOperationsImplement;

        public DatabaseOperationProxy(DatabaseOperations databaseOperations)
        {
            this.DatabaseOperationsImplement = databaseOperations;
        }

        public void Delete()
        {
            Console.WriteLine("BEGIN TRANSCTION");
            try
            {
                DatabaseOperationsImplement.Delete();
                Console.WriteLine("\nCOMMITED TRANSCTION");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSCTION");
            }
        }

        public void Save()
        {
            Console.WriteLine("BEGIN TRANSCTION");
            try
            {
                DatabaseOperationsImplement.Save();
                Console.WriteLine("\nCOMMITED TRANSCTION");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSCTION");
            }
        }

        public void Search()
        {
            Console.WriteLine("BEGIN TRANSCTION");
            try
            {
                DatabaseOperationsImplement.Search();
                Console.WriteLine("\nCOMMITED TRANSCTION");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSCTION");
            }
        }

        public void Update()
        {
            Console.WriteLine("BEGIN TRANSCTION");
            try
            {
                DatabaseOperationsImplement.Update();
                Console.WriteLine("\nCOMMITED TRANSCTION");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSCTION");
            }
        }
    }
}
