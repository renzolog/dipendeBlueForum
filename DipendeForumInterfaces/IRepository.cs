using System;
using System.Collections;
using System.Collections.Generic;

namespace DipendeForumInterfaces
{
    public interface IRepository
    {
        public void Add ();
        public void Delete();
        public void Update();
        public IEnumerable GetAll();
        public  IEnumerable GetById();
    }
    
}
