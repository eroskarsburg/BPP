using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.Tickets;

namespace TicketManagement.DependencyInversion.Databases.GenericDB
{
    public interface IDatabase
    {
        public void Save(Ticket ticket);
    }
}
