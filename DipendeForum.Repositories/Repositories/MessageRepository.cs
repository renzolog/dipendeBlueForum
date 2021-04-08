using DipendeForum.Context.Entities;
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
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        private readonly IMapper _mapper;

        public MessageRepository(ForumDbContext ctx, IMapper mpp) : base (ctx)
        {
            _mapper = mpp;
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
