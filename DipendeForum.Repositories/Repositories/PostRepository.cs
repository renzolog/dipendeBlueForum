﻿using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DipendeForum.Context;
using DipendeForumDomain.DomainClass;

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
            var post = _ctx.Posts.Where(u => u.Id == obj.Id).FirstOrDefault();

            var toUpdate = _ctx.Posts.Where(u => u.Id == obj.Id).FirstOrDefault();
            toUpdate.Messages = post.Messages;
            toUpdate.Category = post.Category;
            toUpdate.Description = post.Description;
            toUpdate.IsClosed = post.IsClosed;
            toUpdate.LastUser = post.LastUser;
            toUpdate.PostPoint = post.PostPoint;
            toUpdate.PublishTime = post.PublishTime;
            toUpdate.Title = post.Title;
            toUpdate.User_Fk = post.User_Fk;
            _ctx.SaveChanges();
        }


        public IEnumerable<PostDomain> GetAll()
        {
            var list = _ctx.Posts;
            var listToGet = _MappingProfiles.ProjectTo<PostDomain>(list);
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
            var postListEntities = _ctx.Posts.Where(p=> p.Id == userId);

            var postDomainList = _MappingProfiles
                .ProjectTo<PostDomain>(postListEntities).ToList();

            return postDomainList;
        }

        public List<PostDomain> GetAllByCategory(Enum category)
        {
            var categoryEntities = _MappingProfiles.Map<Enum>(category);   

            var postDomainList = _MappingProfiles
                .ProjectTo<PostDomain>(IQueryable categoryEntities).ToList();

            return postDomainList;
        }

        public void UpdateIsClosedStatus(int postId)
        {
            var postToUpdate = _ctx.Posts.SingleOrDefault(p => p.Id == postId); //TODO TRY E CATCH

            postToUpdate.IsClosed = !postToUpdate.IsClosed;
        }
    }
}
