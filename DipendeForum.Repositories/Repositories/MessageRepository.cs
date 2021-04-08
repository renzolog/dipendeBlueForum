using DipendeForum.Context.Entities;
using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DipendeForum.Context;
using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces;

namespace DipendeForum.Repositories.Repositories
{
    public class MessageRepository :  IMessageRepository
    {
        private readonly IMapper _MappingProfiles;
        private readonly ForumDbContext _ctx;

        public MessageRepository(ForumDbContext ctx, IMapper mpp)
        {
            _ctx = ctx;
            _MappingProfiles = mpp;
        }
        public void Add(MessageDomain obj)
        {
            var toAdd = _MappingProfiles.Map<Message>(obj);
            _ctx.Messages.Add(toAdd);
            _ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDelete = _ctx.Messages.Where(u => u.Id == id).FirstOrDefault();
            _ctx.Messages.Remove(toDelete);
            _ctx.SaveChanges();
        }

        public void Update(MessageDomain obj)
        {
            var message = _ctx.Messages.Where(u => u.Id == obj.Id).FirstOrDefault();

            var toUpdate = _ctx.Messages.Where(u => u.Id == obj.Id).FirstOrDefault();
            toUpdate.IsReported = message.IsReported;
            toUpdate.MessagePoint = message.MessagePoint;
            toUpdate.Post_Fk = message.Post_Fk;
            toUpdate.PublishTime = message.PublishTime;
            toUpdate.Text = message.Text;
            toUpdate.User_Fk = message.User_Fk;
            _ctx.SaveChanges();
        }


        public IEnumerable<MessageDomain> GetAll()
        {
            var list = _ctx.Messages;
            var listToGet = _MappingProfiles.ProjectTo<MessageDomain>(list);
            return listToGet;
        }

        public MessageDomain GetById(int id)
        {
            var user = _ctx.Messages.Where(u => u.Id == id).FirstOrDefault();
            var userToGet = _MappingProfiles.Map<MessageDomain>(user);
            return userToGet;
        }
    }
}
