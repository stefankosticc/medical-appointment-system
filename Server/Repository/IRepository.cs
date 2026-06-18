using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Repository
{
    public interface IRepository<T> where T : class
    {
        void InsertInto(T entity);
        long InsertIntoOutput(T entity);
        List<T> GetAll(T entity);
        List<T> GetAllByCondition(T entity);
        void Update(T entity);
        void Delete(T entity);
        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
