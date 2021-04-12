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
        private readonly IMapper _mapper;
        private readonly ForumDbContext _ctx;

        public MessageRepository(ForumDbContext ctx, IMapper mpp)
        {
            _ctx = ctx;
            _mapper = mpp;
        }
        public void Add(MessageDomain obj)
        {
            var toAdd = _mapper.Map<Message>(obj);
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
            var listToGet = _mapper.ProjectTo<MessageDomain>(list);
            return listToGet;
        }

        public MessageDomain GetById(int id)
        {
            var message = _ctx.Messages.Where(u => u.Id == id).FirstOrDefault();
            var messageToGet = _mapper.Map<MessageDomain>(message);
            return messageToGet;
        }

        public List<MessageDomain> GetAllByUser(UserDomain userDomain) // passare id?
        {
            var messagesByUser = _ctx.Messages
                .Where(message => message.Id == userDomain.Id);

            var mappedMessages = _mapper.ProjectTo<MessageDomain>(messagesByUser).ToList();

            return mappedMessages;

        }

        public bool UpdateMessageReport(MessageDomain messageDomain)
        {
            var isUpdate = _ctx.Messages
                .Where(message => message.Id == messageDomain.Id)
                .FirstOrDefault();

            isUpdate.IsReported = true;

            return isUpdate.IsReported;
        }
    }
}
