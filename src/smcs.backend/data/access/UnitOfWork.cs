using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace smcs.backend.data.access
{
    internal class UnitOfWork : IUnitOfWork
    {
        public SmcsContext Cntx { get; set; }

        public UnitOfWork(string csName)
        {
            switch (csName)
            {
                case "lab":
                    //NOTE accessing to database on unit tests IS ILLEGAL
                    break;
                case "end-user":
                    this.Cntx = new SmcsContext(ConStrProvider.GetEndUserConStr());
                    break;
                default:
                    throw new ApplicationException("Invalid ConStr on DbProvider ..");
            }
        }

        public bool Commit()
        {
            try
            {
                this.Cntx.SaveChanges();
                return true;
            }
            catch (DbUpdateException e)
            {
                e.Log();
                return false;
            }
            catch (DbEntityValidationException e)
            {
                e.Log();
                return false;
            }
            catch (NotSupportedException e)
            {
                e.Log();
                return false;
            }
            catch (ObjectDisposedException e)
            {
                e.Log();
                return false;
            }
            catch (InvalidOperationException e)
            {
                e.Log();
                return false;
            }
            catch (Exception e)
            {
                e.Log();
                return false;
            }
        }
    }
}
