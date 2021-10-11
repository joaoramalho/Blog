using System;
using System.Collections.Generic;

namespace BlogRepo.Repositories
{
    public class Posts : DBConnection, IRepository<Posts>
    {
        public Posts() : base("")
        {
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Posts Get()
        {
            throw new NotImplementedException();
        }

        public ICollection<Posts> GetCollection()
        {
            throw new NotImplementedException();
        }

        public int Update(Posts obj)
        {
            throw new NotImplementedException();
        }
    }
}
