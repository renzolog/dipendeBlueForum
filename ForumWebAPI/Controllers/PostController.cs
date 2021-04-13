using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;
using DipendeForumInterfaces.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ILogger = NLog.ILogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly ILogger<PostController> _logger;
        public PostController(IPostService postService, ILogger<PostController> logger)
        {
            _postService = postService;
            _logger = logger;
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                _postService.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpPost]
        public ActionResult Post(PostDomain obj)
        {
            try
            {
                _postService.Add(obj);
                return StatusCode(201);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpPut("{obj}")]
        public ActionResult Put(PostDomain obj)
        {
            try
            {
                _postService.Update(obj);
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
                _postService.GetById(id);
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
                _postService.GetAll();
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpGet("{userId}")]
        public ActionResult GetAllByUser(int userId)
        {
            try
            {
                _postService.GetAllByUser(userId);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpPut("{postId}")]
        public ActionResult UpdateIsClosedStatus(int postId)
        {
            try
            {
                _postService.UpdateIsClosedStatus(postId);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpGet ("{category}")]
        public ActionResult GetAllByCategory(CategoryEnum category)
        {
            try
            {
                _postService.GetAllByCategory(category);
                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500, e);
            }
        }

        [HttpPut]
        public ActionResult PointUpDown(int points, int id)
        {
            try
            {
                _postService.PointUpDown(points,id);
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
