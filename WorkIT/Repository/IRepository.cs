using System.Collections.Generic;

namespace WorkIT.Repository
{
    public interface IRepository <Ted>
    {
        void create(Ted item);
        void update(object newWork, Ted item);
        void delete(int id);
        void delete(Ted item);
        List <Ted> get();
        Ted getByID(int id);
        int SaveChanges();
    }
}
