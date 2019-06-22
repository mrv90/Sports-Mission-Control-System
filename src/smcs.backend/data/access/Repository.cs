using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace smcs.backend.data.access
{
    public class Repository<T> : IDisposable where T: class
    {
        IUnitOfWork unOfWrk;

        internal IUnitOfWork GetUnOfWrk { get { return this.unOfWrk; } }

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

        ~Repository()
        {
            //UNDONE System.InvalidOperationException: 'The operation cannot be completed because the DbContext has been disposed.'
            Dispose();
        }

        public bool Add(T t)
        {
            unOfWrk.Cntx.Entry(t).State = EntityState.Added;
            return unOfWrk.Commit();
        }

        /*using IQueryable<T>, we cannot use IDisposalbe On UnitOfWork ..
          because the only way to chech emptiness of generic IQueryable is .Any(), so
          this LINQ extension method needs to access DbContext...or another way ??! */
        public virtual T Ret(Expression<Func<T, bool>> expr)
        {
            /*UNDONE InvalidOperationException: The class 'smcs.backend.data.model.iterative.OffDay' has no parameterless constructor.*/
            /*UNDONE System.InvalidOperationException: 'The entity type UndTreat is not part of the model for the current context.'*/
            /*UNDONE System.NotSupportedException: 'Unable to create a constant value of type 'smcs.backend.data.model.Agent'. 
             * Only primitive types or enumeration types are supported in this context.'*/
            /*UNDONE System.Reflection.TargetException: 'Non-static method requires a target. در صورتیکه عبارت داده شده نامعتبر باشد:*/
            if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).FirstOrDefault();

            return null;
        }

        public virtual IEnumerable<T> RetEnum(Expression<Func<T, bool>> expr)
        {
            /*NOTE توجه شود که استثناها در متدها مشابه در این مورد نیز احتمالا برقرار است*/
            if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).AsEnumerable();

            return null;
        }

        [Obsolete("ظاهرا برای بعضی موارد کار نمیکنه..", true)]
        public virtual T RetMax(Expression<Func<T, bool>> expr)
        {
            /*UNDONE System.NotSupportedException: 'LINQ to Entities does not recognize the method 'smcs.backend.data.model.Agent 
             * LastOrDefault[Agent](System.Linq.IQueryable`1[smcs.backend.data.model.Agent])' method, and this method cannot be translated into a store expression.'*/
            return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).Max();
        }

        public List<T> RetList(Expression<Func<T, bool>> expr)
        {
            /*UNDONE System.InvalidOperationException: 'The model backing the 'SmcsContext' 
             * context has changed since the database was created. Consider using Code First Migrations to update the database (http://*/
            /*UNDONE SqlException: Resetting the connection results in a different state than the initial login. The login fails.
               Login failed for user 'sa'.
               A severe error occurred on the current command.  The results, if any, should be discarded.*/
            /*UNDONE InvalidOperationException: The class 'smcs.backend.data.model.basic.Rank' has no parameterless constructor.*/
            if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).ToList();

            return null;
        }

        public double RetRoundedAvg(Expression<Func<T, bool>> cond, Expression<Func<T, double>> expr)
        {
            if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
            {
                var result = unOfWrk.Cntx.Set<T>().AsNoTracking().Where(cond);
                if (result.Any())
                    return Math.Round(result.Average(expr), 1);
            }

            return 0.0d;
        }

        internal bool Upd(T t)
        {
            unOfWrk.Cntx.Entry(t).State = EntityState.Modified;
            //unOfWrk.Cntx.Set<T>().Attach(t); // this method prevent dbcontext from saving ..
            /*System.InvalidOperationException: 'Attaching an entity of type 'smcs.backend.data.model.Signature' failed because 
            another entity of the same type already has the same primary key value. This can happen when using the 'Attach' method 
            or setting the state of an entity to 'Unchanged' or 'Modified' if any entities in the graph have conflicting key values. 
            This may be because some entities are new and have not yet received database-generated key values. In this case use the 'Add' 
            method or the 'Added' entity state to track the graph and then set the state of non-new entities to 'Unchanged' or 'Modified' as appropriate.'*/
            return unOfWrk.Commit();
        }

        internal bool Del(T t)
        {
            T existing = unOfWrk.Cntx.Set<T>().Find(t);
            if (existing != null)
                unOfWrk.Cntx.Set<T>().Remove(t);

            return unOfWrk.Commit();
        }

        public void Dispose()
        {
            if (csName == "end-user")
                this.unOfWrk.Cntx.Dispose();
        }
    }
}