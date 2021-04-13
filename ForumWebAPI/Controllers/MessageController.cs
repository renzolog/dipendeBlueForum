﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DipendeForumDomain.DomainClass;
using DipendeForumInterfaces.Iservice;
using DipendeForumService;
using Microsoft.Extensions.Logging;

namespace ForumWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly ILogger<MessageController> _logger;

        public MessageController(IMessageService messageService, ILogger<MessageController> logger)
        {
            _messageService = messageService;
            _logger = logger;
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e); 
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e); 
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e); 
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e); 
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
                _logger.LogError(e, e.Message);
                return StatusCode(500, e); 
            }
        }
    }
}
