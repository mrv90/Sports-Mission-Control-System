using Backend.Data.Model.Parent;
using smcs.backend.data.model;
using smcs.backend.data.model.iterative;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace smcs.backend.data.access
{
    public class Repository<T> : IDisposable where T: class
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

        public Repository<T> AddSingle(T t)
        {
            unOfWrk.Cntx.Entry(t).State = EntityState.Added;
            return this;
        }

        public Repository<T> AddMultiple(T t)
        {
            if (typeof(T).Name == "Absence")
                unOfWrk.Cntx.Absence.Add(t as Absence);

            else if (typeof(T).Name == "OffDay")
                unOfWrk.Cntx.OffDay.Add(t as OffDay);

            else if (typeof(T).Name == "OnDuty")
                unOfWrk.Cntx.OnDuty.Add(t as OnDuty);

            else if (typeof(T).Name == "UndTreat")
                unOfWrk.Cntx.UndTreat.Add(t as UndTreat);

            else if (typeof(T).Name == "Agent")
                unOfWrk.Cntx.Agent.Add(t as Agent);

            else if (typeof(T).Name == "Mission")
                unOfWrk.Cntx.Mission.Add(t as Mission);

            else if (typeof(T).Name == "Session")
                unOfWrk.Cntx.Session.Add(t as Session);

            else if (typeof(T).Name == "User")
                unOfWrk.Cntx.User.Add(t as User);

            else {
                // UNDONE یه استنای برنامه‌ای با متن موجودیت ثبت نشده، ایجاد شود
            }

            return this;
        }

        public virtual T Ret(Expression<Func<T, bool>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).FirstOrDefault();
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

        public virtual IEnumerable<T> RetEnum(Expression<Func<T, bool>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).AsEnumerable();
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

        public virtual T RetMax(Expression<Func<T, bool>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                    return unOfWrk.Cntx.Set<T>().AsNoTracking().OrderByDescending(expr).First();
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

        public List<T> RetList(Expression<Func<T, bool>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any()) 
                    return unOfWrk.Cntx.Set<T>().AsNoTracking().Where(expr).ToList();
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

        public double RetRoundedAvg(Expression<Func<T, bool>> cond, Expression<Func<T, double>> expr)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                {
                    var result = unOfWrk.Cntx.Set<T>().AsNoTracking().Where(cond);
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

        internal Repository<T> Upd(T t)
        {
            unOfWrk.Cntx.Entry(t).State = EntityState.Modified;
            return this;
        }

        internal bool RemSngl(T t)
        {
            T existing = unOfWrk.Cntx.Set<T>().Find(t);
            if (existing != null)
            {
                (t as Enabler).Enbl = false;
                unOfWrk.Cntx.Entry(t).State = EntityState.Modified;
            }

            return unOfWrk.Commit();
        }

        internal Repository<T> RemCond(Expression<Func<T, bool>> cond)
        {
            try
            {
                if (unOfWrk.Cntx.Set<T>().AsNoTracking().Any())
                {
                    var list = unOfWrk.Cntx.Set<T>().AsNoTracking().Where(cond).ToList();
                    if (list != null && list.Count > 0)
                    {
                        foreach (var i in list)
                        {
                            (i as Enabler).Enbl = false;
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