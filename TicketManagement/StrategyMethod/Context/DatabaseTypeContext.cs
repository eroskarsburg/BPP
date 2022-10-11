using System;
using System.Collections.Generic;
using System.Text;
using TicketManagement.DependencyInversion.Databases;
using TicketManagement.DependencyInversion.Databases.GenericDB;
using TicketManagement.DependencyInversion.Databases.System;
using TicketManagement.StrategyMethod.Strategy;
using TicketManagement.Tickets;

namespace TicketManagement.StrategyMethod.Context
{
    public class DatabaseTypeContext
    {
        public DatabaseSystem GetStrategyDatabase(string database)
        {
            if (database == "SQL")
            {
                SQLDatabase sqlDB = new SQLDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(sqlDB);
                return databaseSystem;
            }
            if (database == "ORACLE")
            {
                OracleDatabase oracleDB = new OracleDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(oracleDB);
                return databaseSystem;
            }
            if (database == "MYSQL")
            {
                MySqlDatabase mySqlDB = new MySqlDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(mySqlDB);
                return databaseSystem;
            }
            if (database == "PHP")
            {
                PHPDatabase phpDB = new PHPDatabase();
                DatabaseSystem databaseSystem = new DatabaseSystem(phpDB);
                return databaseSystem;
            }

            throw new Exception("Invalid Database.");
        }
    }
}
