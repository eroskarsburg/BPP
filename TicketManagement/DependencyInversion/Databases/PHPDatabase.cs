using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.Tickets;

namespace TicketManagement.DependencyInversion.Databases
{
    public class PHPDatabase : IDatabase
    {
        public void Save(Ticket ticket)
        {
            Console.WriteLine("Saving in PHP database.");
        }
    }
}
