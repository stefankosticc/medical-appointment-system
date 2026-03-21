using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;

        public Broker()
        {
            connection = new DbConnection();
        }

        public void OpenConnection() => connection.OpenConnection();

        public void CloseConnection() => connection.CloseConnection();

        public void Commit() => connection.Commit();

        public void Rollback() => connection.Rollback();

        public void BeginTransaction() => connection.BeginTransaction();

        public SqlCommand CreateCommand() => connection.CreateCommand();

    }
}
