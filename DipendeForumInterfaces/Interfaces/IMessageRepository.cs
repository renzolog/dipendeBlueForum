using System;
using DipendeForum.Context.Entities;
using System.Collections.Generic;
using DipendeForumDomain.DomainClass;

namespace DipendeForumInterfaces.Interfaces
{
    public interface IMessageRepository : IRepository<MessageDomain>
    {
        List<MessageDomain> GetAllByUser(UserDomain userDomain);
        bool UpdateMessageReport(MessageDomain messageDomain);
    }
}
