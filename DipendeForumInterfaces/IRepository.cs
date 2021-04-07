using System;
using System.Collections;
using System.Collections.Generic;

namespace DipendeForumInterfaces
{
    public interface IRepository<T>
    {
        public void Add ();
        public void Delete();
        public void Update();
        public IEnumerable<T> GetAll();
        public  T GetById();
    }
    
}
