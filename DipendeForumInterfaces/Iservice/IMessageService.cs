using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.DomainClass;

namespace DipendeForumInterfaces.Iservice
{
   public interface IMessageService
    {
        public void Add(MessageDomain obj);


        public void Delete(int id);


        public void Update(MessageDomain obj);



        public IEnumerable<MessageDomain> GetAll();

        public MessageDomain GetById(int id);
        public List<MessageDomain> GetAllByUser(UserDomain userDomain);
        public bool UpdateMessageReport(MessageDomain messageDomain);
        public List<MessageDomain> getAllByPost(PostDomain post);
    }
}
