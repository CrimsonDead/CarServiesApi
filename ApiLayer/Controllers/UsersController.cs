using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Repository;

namespace ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IRepository<User> _repository;

        public UsersController(IRepository<User> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> Users()
        {
            List<User> users = null;
            try
            {
                users = _repository.GetItems().ToList();
                if (users.Count == 0)
                    return NotFound();
            }
            catch 
            {
                return BadRequest();
            }
            return Ok(users);
        }

        [HttpGet("{id}", Name ="User")]
        public ActionResult<User> UserById(int id)
        {
            User user = null;
            try
            {
                user = _repository.GetItem(id);
                if (user == null)
                    return NotFound();
            }
            catch
            {
                return BadRequest();
            }
            return Ok(user);
        }

        [HttpPost("Create")]
        public void Create([FromBody] User user)
        {
            _repository.Add(user);
        }

        [HttpPut("Update")]
        public void Update([FromBody] User user)
        {
            _repository.Update(user);
        }

        [HttpDelete("Delete/{id}")]
        public void Delete(int id)
        {
            var entity = _repository.GetItem(id);
            _repository.Delete(entity);
        }
    }
}
