using DipendeForumInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DipendeForumDomain.DomainClass;

namespace DipendeForumService
{
    public class MessageService
    {
        private readonly IMessageRepository repo;

        public MessageService(IMessageRepository _repo)
        {
            repo = _repo;
        }

        public void Add(MessageDomain obj)
        {
            if (obj == null)
                throw new Exception("Message can't be null.");

            repo.Add(obj);
        }

        public void Delete(int id)
        {
            if (repo.GetById(id) == null)
                throw new Exception();

            else
            {
                repo.Delete(id);
            }
        }

        public void Update(MessageDomain obj)
        {
            if (obj == null)
                throw new Exception("");
            if (repo.GetById(obj.Id) == null)
                throw new Exception("Id don't exist.");

            var objToUpdate = repo.GetById(obj.Id);

            if (obj.MessagePoint == null)
                obj.MessagePoint = objToUpdate.MessagePoint;
            if(obj.Post_Fk != objToUpdate.Post_Fk)
                throw new Exception("FK can't change.");
            if (obj.PublishTime == null)
                obj.PublishTime = objToUpdate.PublishTime;
            if (obj.Text == null)
                obj.Text = objToUpdate.Text;
            if (obj.User_Fk != null)
                throw new Exception("FK can't change.");
            if (obj.IsReported == null)
                obj.IsReported = objToUpdate.IsReported;

            repo.Update(obj);
        }

        public IEnumerable<MessageDomain> GetAll()
        {
            return repo.GetAll();
        }

        public MessageDomain GetById(int id)
        {
            var message = repo.GetById(id);

            if(message == null)
                throw new Exception("");
            else
            {
                return message;
            }
        }

        public List<MessageDomain> GetAllByUser(UserDomain userDomain)
        {
            var listMessages = repo.GetAllByUser(userDomain);

            if (listMessages == null)
                throw new Exception("User not found.");
            else
            {
                return listMessages;
            }
        }

        public bool UpdateMessageReport(MessageDomain messageDomain)
        {
            if (messageDomain == null)
                throw new Exception("");
            else
            {
                return repo.UpdateMessageReport(messageDomain);
            }

        }

        public List<MessageDomain> getAllByPost(PostDomain post)
        {
            var listPosts = repo.getAllByPost(post);

            if (listPosts == null)
                throw new Exception("Post can't be null.");
            else
            {
                return listPosts;
            }

        }
    }
}
