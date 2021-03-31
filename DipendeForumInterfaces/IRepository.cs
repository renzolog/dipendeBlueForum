using System;

namespace DipendeForumInterfaces
{
    public interface IRepository<T>
    {
        public void Add <T>();
        public void Delete<T>();
        public void Update<T>();
        public T GetAll();
        public T GetById();
    }
    
}
