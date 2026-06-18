using Common.Domain;
using DBBroker;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Server.Repository
{
    internal class GenericDbRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Delete(IDomainObject entity)
        {
            SqlCommand cmnd = broker.CreateCommand();
            cmnd.CommandText = $"DELETE FROM {entity.TableName} WHERE {entity.PrimaryKeyClause}";
            Debug.WriteLine(cmnd.CommandText);
            cmnd.ExecuteNonQuery();
            cmnd.Dispose();
        }

        public List<IDomainObject> GetAll(IDomainObject entity)
        {
            SqlCommand cmnd = broker.CreateCommand();
            cmnd.CommandText = $"SELECT {entity.SelectColumns} FROM {entity.TableName} {entity.JoinClause}";
            Debug.WriteLine(cmnd.CommandText);
            using SqlDataReader reader = cmnd.ExecuteReader();
            List<IDomainObject> list = entity.All(reader);
            cmnd.Dispose();
            return list;
        }

        public List<IDomainObject> GetAllByCondition(IDomainObject entity)
        {
            SqlCommand cmnd = broker.CreateCommand();
            cmnd.CommandText = $"SELECT {entity.SelectColumns} FROM {entity.TableName} {entity.JoinClause} WHERE {entity.WhereClause}";
            Debug.WriteLine(cmnd.CommandText);
            using SqlDataReader reader = cmnd.ExecuteReader();
            List<IDomainObject> list = entity.All(reader);
            cmnd.Dispose();
            return list;
        }

        public void InsertInto(IDomainObject entity)
        {
            SqlCommand cmnd = broker.CreateCommand();
            cmnd.CommandText = $"INSERT INTO {entity.TableName} ({entity.InsertColumns}) VALUES ({entity.InsertValues})";
            Debug.WriteLine(cmnd.CommandText);
            cmnd.ExecuteNonQuery();
            cmnd.Dispose();
        }

        public long InsertIntoOutput(IDomainObject entity)
        {
            SqlCommand cmd = broker.CreateCommand();
            cmd.CommandText = $"INSERT INTO {entity.TableName} ({entity.InsertColumns}) OUTPUT INSERTED.id VALUES ({entity.InsertValues})";
            object result = cmd.ExecuteScalar();
            cmd.Dispose();
            return Convert.ToInt64(result);
        }

        public void Update(IDomainObject entity)
        {
            SqlCommand cmnd = broker.CreateCommand();
            cmnd.CommandText = $"UPDATE {entity.TableName} SET {entity.SetClause} WHERE {entity.PrimaryKeyClause}";
            Debug.WriteLine(cmnd.CommandText);
            cmnd.ExecuteNonQuery();
            cmnd.Dispose();
        }
    }
}
