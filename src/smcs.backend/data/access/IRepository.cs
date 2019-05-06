using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace smcs.backend.data.access
{
    public interface IRepository<T> where T: class
    {
        bool Add(T t);

        T Ret(Expression<Func<T, bool>> expr);

        T RetMax(Expression<Func<T, bool>> expr);

        List<T> RetList(Expression<Func<T, bool>> expr);

        bool Upd(T t);

        bool Del(T t);
    }
}
