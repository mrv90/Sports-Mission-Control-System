using System;
using System.Data.Entity.Infrastructure;

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
                /*UNDONE Validation failed for one or more entities. See 'EntityValidationErrors' property for more details. */
                this.Cntx.SaveChanges();
                return true;
            }
            catch (DbUpdateException e)
            {
                // UNDONE log this
                /*Cannot insert duplicate key row in object 'dbo.Agent' with unique index 'IX_PersCode'.The duplicate key value is (0).
                  The statement has been terminated.*/
            }

            return false;
        }
    }
}
