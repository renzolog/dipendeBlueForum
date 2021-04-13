using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DipendeForum.Context;
using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;

namespace DipendeForum.Repositories.Repositories
{
    public class PostRepository :  IPostRepository
    {
        private readonly IMapper _MappingProfiles;
        private readonly ForumDbContext _ctx;

        public PostRepository(ForumDbContext ctx, IMapper mpp)
        {
            _ctx = ctx;
            _MappingProfiles = mpp;
        }
        public void Add(PostDomain obj)
        {
            var toAdd = _MappingProfiles.Map<Post>(obj);
            _ctx.Posts.Add(toAdd);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDelete = _ctx.Posts.Where(u => u.Id == id).FirstOrDefault();
            _ctx.Posts.Remove(toDelete);
            _ctx.SaveChanges();
        }

        public void Update(PostDomain obj)
        {
            var update = _MappingProfiles.Map<Post>(obj);
            _ctx.Posts.Update(update);
            _ctx.SaveChanges();
        }


        public List<PostDomain> GetAll()
        {
            var list = _ctx.Posts;
            var listToGet = _MappingProfiles.ProjectTo<PostDomain>(list).ToList();
            return listToGet;
        }

        public PostDomain GetById(int id)
        {               
            var user = _ctx.Posts.FirstOrDefault(u => u.Id == id);
            var userToGet = _MappingProfiles.Map<PostDomain>(user);
                    
            return userToGet;
        }

        public List<PostDomain> GetAllByUser(int userId)
        {              
            var postListEntities = _ctx.Posts.Where(p => p.Id == userId);
            var postDomainList = _MappingProfiles
                .ProjectTo<PostDomain>(postListEntities).ToList();     

            return postDomainList;          
        }
        
        public List<PostDomain> GetAllByCategory(CategoryEnum category)
        {                            
            var categoryEntities = _ctx.Posts.Where(c => c.Category == (byte)category);   
            var postDomainList = _MappingProfiles
                .ProjectTo<PostDomain>(categoryEntities).ToList(); 
 
            return postDomainList;
        }

        public void UpdateIsClosedStatus(int postId)
        {            
            var postToUpdate = _ctx.Posts.SingleOrDefault(p => p.Id == postId); 
                postToUpdate.IsClosed = !postToUpdate.IsClosed;       
           
        }
    }
}
