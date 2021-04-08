using DipendeForum.Context.Entities;
using DipendeForumInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DipendeForum.Context;

namespace DipendeForum.Repositories.Repositories
{
    public class Repository<T> : IRepository<T>
    {
        protected readonly ForumDbContext _ctx;
        public Repository(ForumDbContext ctx)
        {
            _ctx = ctx;
        }
        public void Add(T obj)
        {
            switch (typeof(T).Name)
            {
                case ("User"):
                    _ctx.User.Add(obj);
                    break;

                case ("Post"):
                    _ctx.Post.Add(obj);
                    break;

                case ("Message"):
                    _ctx.User.Add(obj);
                    break;

                Default:
                    throw new Exception("Mbecille che hai postato?");
                    break;
            }
            _ctx.SaveChanges();

        }

        public void Delete( int id)
        {
            switch (typeof(T).Name) {
            case ("User"):
                var toDeleteUser = _ctx.User.Where(u=>u.Id == id).FirstOrDefault();
                _ctx.User.Remove(toDeleteUser);
                break;

            case ("Post"):
                var toDeletePost = _ctx.Post.Where(u => u.Id == id).FirstOrDefault();
                _ctx.Post.Remove(toDeletePost);

                break;

            case ("Message"):
                var toDeleteMessage = _ctx.Message.Where(u => u.Id == id).FirstOrDefault();
                _ctx.Message.Remove(toDeleteMessage);

                break;

            Default:
                throw new Exception("Mbecille che hai postato?");
                break;
        }
            _ctx.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            switch (typeof(T).Name)
            {
                case ("User"):
                    var listUser = _ctx.User;
                    return listUser;
                    break;

                case ("Post"):
                    var listPost = _ctx.Post;
                    return listPost;

                    break;

                case ("Message"):
                    var listMessage = _ctx.Message;
                    return listMessage;

                    break;

                    Default:
                    throw new Exception("Mbecille che hai postato?");
                    break;

            }

            return null;
        }

        public T GetById(int id)
        {
            switch (typeof(T).Name)
            {
                case ("User"):
                    var User = _ctx.User.Where(u => u.Id == id).FirstOrDefault();
                    return User;
                    break;

                case ("Post"):
                    var Post = _ctx.Post.Where(u => u.Id == id).FirstOrDefault();
                    return Post;
                    break;

                    break;

                case ("Message"):
                    var Message = _ctx.Message.Where(u => u.Id == id).FirstOrDefault();
                    return Message;

                    break;
            }
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
