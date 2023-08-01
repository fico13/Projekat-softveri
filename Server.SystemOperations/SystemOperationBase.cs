using Common.Domain;
using Server.Repository.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDBRepository();

        public void ExecuteTemplate()
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch(Exception ex)
            {
                repository.Rollback();
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                repository.CloseConnection();
            }
        }

        protected abstract void Execute();
    }
}
