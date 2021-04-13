using System.Collections.Generic;

namespace DipendeForumInterfaces
{
    public interface IRepository<T>
    {
        public void Add (T obj);
        public void Delete(int id);
        public void Update(T obj);
        public List<T> GetAll();
        public  T GetById(int id);
    }
}
