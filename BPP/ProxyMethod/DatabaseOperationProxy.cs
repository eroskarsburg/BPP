using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            DateTime dateTimeInicio = DateTime.Now;
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                DatabaseOperationsImplement.Delete();
                Thread.Sleep(5000);
                Console.WriteLine("COMMITED TRANSACTION\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSACTION");
            }
            DateTime dateTimeFim = DateTime.Now;

            Console.WriteLine("Execution time: " + dateTimeFim.Subtract(dateTimeInicio));
        }

        public void Save()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                DatabaseOperationsImplement.Save();
                Console.WriteLine("COMMITED TRANSACTION\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSACTION");
            }
        }

        public void Search()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                DatabaseOperationsImplement.Search();
                Console.WriteLine("COMMITED TRANSACTION\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSACTION");
            }
        }

        public void Update()
        {
            Console.WriteLine("BEGIN TRANSACTION");
            try
            {
                DatabaseOperationsImplement.Update();
                Console.WriteLine("COMMITED TRANSACTION\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ROLLBACK TRANSACTION");
            }
        }
    }
}
