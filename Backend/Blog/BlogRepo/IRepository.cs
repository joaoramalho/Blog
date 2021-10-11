using System;
using System.Collections.Generic;

namespace BlogRepo
{
    public interface IRepository<T>
    {
        T Get();
        ICollection<T> GetCollection();
        int Update(T obj);
        int Delete(int id);
    }
}
