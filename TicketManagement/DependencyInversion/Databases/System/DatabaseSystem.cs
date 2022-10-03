using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.Tickets;

namespace TicketManagement.DependencyInversion.Databases.System
{
    public class DatabaseSystem
    {
        public IDatabase Database { get; set; }

        public DatabaseSystem(IDatabase database)
        {
            this.Database = database;
        }

        public void Save(Ticket ticket)
        {
            Database.Save(new Ticket());
        }
    }
}
