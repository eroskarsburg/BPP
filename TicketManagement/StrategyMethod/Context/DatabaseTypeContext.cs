using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.DependencyInversion.Databases.System;
using TicketManagement.Tickets;

namespace TicketManagement.StrategyMethod.Context
{
    public class DatabaseTypeContext
    {
        public IDatabase GetStrategyDatabase(string database)
        {
            if (database == "SQL")
            {
                SQLDatabase sqlDB = new SQLDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(sqlDB);
                databaseSystem.Save(new Ticket());
            }
            if (database == "ORACLE")
            {
                OracleDatabase oracleDB = new OracleDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(oracleDB);
                databaseSystem.Save(new Ticket());
            }
            if (database == "MYSQL")
            {
                MySqlDatabase mySqlDB = new MySqlDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(mySqlDB);
                databaseSystem.Save(new Ticket());
            }
            if (database == "PHP")
            {
                PHPDatabase phpDB = new PHPDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(phpDB);
                databaseSystem.Save(new Ticket());
            }

            throw new Exception("Invalid Database.");
        }
    }
}
