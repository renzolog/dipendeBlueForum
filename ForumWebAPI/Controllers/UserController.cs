using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces.Interfaces;
using DipendeForumInterfaces.Iservice;

namespace ForumWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult Add(UserDomain userDomain)
        {
            try
            {
                _service.Add(userDomain);
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
                _service.Delete(id);
                return Accepted();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }


        }

        [HttpGet]
        public ActionResult<List<UserDomain>> GetAll()
        {
            try
            {
              var list=  _service.GetAll();
                return Ok(list);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpGet("{id}")]
        public ActionResult<UserDomain> GetById(int id)
        { 
            try
            {
               var user= _service.GetById(id);
                return Ok(user);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        [HttpGet("{username}")]
        public ActionResult<UserDomain> GetByUsername(string username)
        {
            try
            {
                var user = _service.GetByUsername(username);
                return Ok(user);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPatch]
        public ActionResult Update(UserDomain userDomain)
        {
            try
            {
                _service.Update(userDomain);
                return Accepted();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPatch("ban")]
        public ActionResult UpdateUserToBan(int id, DateTime _date)
        {
            try
            {
                _service.UpdateUserToBan(id, _date);
                return Accepted();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

    }
}
