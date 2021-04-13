using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces.Iservice;
using DipendeForumService;

namespace ForumWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _messageService.Delete(id);
                return Ok();

            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public ActionResult Add(MessageDomain obj)
        {
            try
            {
                _messageService.Add(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public ActionResult Update(MessageDomain obj)
        {
            try
            {
                _messageService.Update(obj);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            try
            {
                _messageService.GetById(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500); ;
            }
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                _messageService.GetAll();
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500); ;
            }
        }

        [HttpGet("{userDomain}")]
        public ActionResult GetAllByUser(UserDomain userDomain)
        {
            try
            {
                _messageService.GetAllByUser(userDomain);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500); ;
            }
        }

        [HttpPut("{messageDomain}")]
        public ActionResult UpdateMessageReport(MessageDomain messageDomain)
        {
            try
            {
                _messageService.UpdateMessageReport(messageDomain);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500); ;
            }
        }

        [HttpGet("{post}")]
        public ActionResult getAllByPost(PostDomain post)
        {
            try
            {
                _messageService.getAllByPost(post);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500); ;
            }
        }
    }
}
