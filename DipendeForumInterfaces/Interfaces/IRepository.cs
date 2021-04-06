using System;

namespace DipendeForum.Context.Interfaces
{
    public interface IRepository<T>
    {
        public void Add();
        public void Delete();
        public void Update();
        public T GetAll();
        public T GetById();
    }
}
