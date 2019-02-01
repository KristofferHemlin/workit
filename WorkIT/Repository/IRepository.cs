using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WorkIT.Repository
{
    public interface IRepository <Ted>
    {
        void create(Ted item);
        void update(Ted item);
        void delete(int id);
        void delete(Ted item);
        List<Ted> get();
        List<Ted> get(Expression<Func<Ted, bool>> predicate);
        Ted getByID(int id);
        int SaveChanges();
    }
}
