using System;
using System.Collections.Generic;

namespace DipendeForum.Context.Interfaces
{
    public interface IRepository<T>
    {
        public void Add();
        public void Delete();
        public void Update();
        public List<T> GetAll();
        public T GetById();
    }
}
