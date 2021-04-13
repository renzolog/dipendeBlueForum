using System;
using System.Collections.Generic;
using System.Text;
using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;

namespace DipendeForumInterfaces.Iservice
{
 public   interface IPostService
 {
     public void Delete(int id);

     public void Add(PostDomain obj);
     public void Update(PostDomain obj);

     public PostDomain GetById(int id);
     public List<PostDomain> GetAll();
     public List<PostDomain> GetAllByUser(int userId);

     public List<PostDomain> GetAllByCategory(CategoryEnum category);
     public void UpdateIsClosedStatus(int postId);
     public void PointUpDown(int points, int id);
 }
}
