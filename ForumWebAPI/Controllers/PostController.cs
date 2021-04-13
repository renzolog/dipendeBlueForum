using DipendeForumDomain.DomainClass;
using DipendeForumDomain.Enum;
using DipendeForumInterfaces.Iservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public PostController(IPostService postService)
        {
            _postService = postService;
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
                return StatusCode(500);
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
                return StatusCode(500);
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
                return StatusCode(500);
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
                return StatusCode(500);
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
                return StatusCode(500);
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
            catch (Exception)
            {
                return StatusCode(500);
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
            catch (Exception)
            {
                return StatusCode(500);
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
                return StatusCode(500);
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

                return StatusCode(500);
            }
        }
    }
}
