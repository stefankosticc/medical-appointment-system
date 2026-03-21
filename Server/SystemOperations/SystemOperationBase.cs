using Common.Domain;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDbRepository();

        public void OpsteIzvrsenjeSO()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();

                IzvrsenjeSO();

                repository.Commit();
            }
            catch (Exception ex)
            {
                repository.Rollback();
                throw new Exception(ex.Message);
            }
        }

        protected abstract void IzvrsenjeSO();
    }

}
