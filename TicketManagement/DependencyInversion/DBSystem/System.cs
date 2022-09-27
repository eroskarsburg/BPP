using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases.GenericDB;

namespace TicketManagement.DependencyInversion.DBSystem
{
    public class System
    {
        public IDatabase Database { get; set; }

        public System(IDatabase database)
        {
            this.Database = database;
        }
    }
}
