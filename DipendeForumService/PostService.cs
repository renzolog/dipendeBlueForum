using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DipendeForumInterfaces.Iservice;

namespace DipendeForumService
{
    public class PostService : IPostService
    {
        private readonly IPostRepository repo;

        public PostService(IPostRepository _repo)
        {
            repo = _repo;
        }

        public void Delete(int id)
        {
            if (repo.GetById(id) == null)
                throw new Exception("L'elemento con id associato non esiste");
            
            repo.Delete(id);
        }

        public void Add(PostDomain obj)
        {
            if (obj == null)
                throw new Exception("Non puoi aggiungere un post null");
            
            repo.Add(obj);
        }
        
        public void Update(PostDomain obj)
        {
            if (obj == null)
                throw new Exception("obj non può essere vuoto");
           
            repo.Update(obj);
        }

        public PostDomain GetById(int id)
        {
            if ((repo.GetAll().FirstOrDefault(p => p.Id == id) == null))
                throw new Exception("L' Id associato non può essere vuoto");
            
            return repo.GetById(id);
        }

        public List<PostDomain> GetAll()
        {
            return repo.GetAll();
        }

        public List<PostDomain> GetAllByUser(int userId)
        {
            if (repo.GetAll().FirstOrDefault(u=>u.User_Fk.Id == userId) == null)
                throw new Exception("UserId non può essere vuoto");
            
            return repo.GetAllByUser(userId);
        }

        public List<PostDomain> GetAllByCategory(CategoryEnum category)
        {   
           return repo.GetAllByCategory(category);
        }

        public void UpdateIsClosedStatus(int postId)
        {
            if (repo.GetAll().FirstOrDefault(u => u.Id == postId) == null)
                throw new Exception("PostId associato non può essere vuoto");

            repo.UpdateIsClosedStatus(postId);
        }

        public void PointUpDown (int points, int id)
        {
            if  (points >= 10 || points <=10)
                throw new Exception("Il punteggio inserito non può superare 10");

            if ((repo.GetAll().FirstOrDefault(p => p.Id == id) == null))
                throw new Exception("L' Id associato non può essere vuoto");

            var PostId = repo.GetById(id);
            PostId.PostPoint += points;
            repo.Update(PostId);            
        }
    }
}
