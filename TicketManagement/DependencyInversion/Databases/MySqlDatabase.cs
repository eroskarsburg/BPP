using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.Tickets;

namespace TicketManagement.DependencyInversion.Databases
{
    public class MySqlDatabase : IDatabase
    {
        public void Save(Ticket ticket)
        {
            Console.WriteLine("Saving in MySql database.");
        }
    }
}
