using smcs.backend.data.model.parent;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace smcs.backend.data.access
{
    public class Repository : IDisposable
    {
        IUnitOfWork unOfWrk;

        private readonly string csName = "end-user";

        public Repository()
        {
            this.unOfWrk = new UnitOfWork(csName);
        }

        public Repository(string cs)
        {
            csName = cs;
            this.unOfWrk = new UnitOfWork(csName);
        }

        public TEntity Ret<TEntity>(Expression<Func<TEntity, bool>> expr) where TEntity: Base
        {
            try
            {
                if (unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Where(expr).FirstOrDefault();
            }
            catch (InvalidOperationException e)
            {
                e.Log();
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (NotSupportedException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return null;
        }

        public IEnumerable<TEntity> RetEnum<TEntity>(Expression<Func<TEntity, bool>> expr) where TEntity : Base
        {
            try
            {
                if (unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Where(expr).AsEnumerable();
            }
            catch (InvalidOperationException e)
            {
                e.Log();
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (SqlException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return null;
        }

        public TEntity RetMax<TEntity>(Expression<Func<TEntity, bool>> expr) where TEntity : Base
        {
            try
            {
                if (unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<TEntity>().AsNoTracking().OrderByDescending(expr).First();
            }
            catch (NotSupportedException e)
            {
                e.Log();
            }
            catch (InvalidOperationException e)
            {
                e.Log();
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (SqlException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return null;
        }

        public List<TEntity> RetList<TEntity>(Expression<Func<TEntity, bool>> expr) where TEntity : Base
        {
            try
            {
                if (unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Any()) 
                    return unOfWrk.Cntx.Set<TEntity>().AsNoTracking().Where(expr).ToList();
            }
            catch (DataException e)
            {
                e.Log();
            }
            catch (InvalidOperationException e)
            {
                e.Log();
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (SqlException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return null;
        }

        public double RetRoundedAvg<TEntity>(Expression<Func<Base, bool>> cond, Expression<Func<Base, double>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<Base>().AsNoTracking().Any())
                {
                    var result = unOfWrk.Cntx.Set<Base>().AsNoTracking().Where(cond);
                    if (result.Any())
                        return Math.Round(result.Average(expr), 1);
                }
            }
            catch (InvalidOperationException e)
            {
                e.Log();
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (SqlException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return 0.0d;
        }

        internal Repository Add<TEntity>(TEntity t) where TEntity : Base
        {
            unOfWrk.Cntx.Set(t.GetType()).Add(t);
            unOfWrk.Cntx.Entry(t).State = EntityState.Added;
            return this;
        }

        internal Repository Upd<TEntity>(TEntity t) where TEntity : Base
        {
            unOfWrk.Cntx.Set(t.GetType()).Attach(t);
            unOfWrk.Cntx.Entry(t).State = EntityState.Modified;
            return this;
        }

        internal Repository Rem<TEntity>(TEntity t) where TEntity : Base
        {
            var exist = unOfWrk.Cntx.Set<Base>().Find(t);
            if (exist != null)
            {
                t.Enbl = false;
                unOfWrk.Cntx.Entry(t).State = EntityState.Modified;
            }

            return this;
        }

        internal Repository Rem<TEntity>(Expression<Func<Base, bool>> cond)
        {
            try
            {
                if (unOfWrk.Cntx.Set<Base>().AsNoTracking().Any())
                {
                    var list = unOfWrk.Cntx.Set<Base>().AsNoTracking().Where(cond).ToList();
                    if (list != null && list.Count > 0)
                    {
                        foreach (var i in list)
                        {
                            i.Enbl = false;
                            unOfWrk.Cntx.Entry(i).State = EntityState.Modified;
                        }
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                e.Log();
            }
            catch (SqlException e)
            {
                e.Log();
            }
            catch (Exception e)
            {
                e.Log();
            }

            return this;
        }

        public bool Commit()
        {
            return unOfWrk.Commit();
        }

        public void Dispose()
        {
            if (csName == "end-user")
                this.unOfWrk.Cntx.Dispose();
        }
    }
}