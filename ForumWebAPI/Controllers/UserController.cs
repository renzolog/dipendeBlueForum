using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces.Interfaces;

namespace ForumWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;

        public UserController(IUserRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public ActionResult Add(UserDomain userDomain)
        {
            try
            {
                _repo.Add(userDomain);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        [HttpDelete]
        public ActionResult Delete (int id)
        {
            try
            {
                _repoAccount.DeleteByUserId(id);
                _repoCustomer.Delete(id);
                return StatusCode(201);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }
    }
}
