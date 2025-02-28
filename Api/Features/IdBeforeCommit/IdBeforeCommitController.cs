using Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text;
using System.Text.Json;
using System.Linq.Dynamic.Core;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Api.Entities;
using Api.Dtos;

namespace Api.Features.DynamicSelect
{
    [ApiController]
    [Route("[controller]")]
    public class IdBeforeCommitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IdBeforeCommitController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("AddUser")]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto userDto)
        {
            User user = new User(userDto.Name);
            using (var tran = await _context.Database.BeginTransactionAsync())
            {
                var result = await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                int id = user.Id;

                if (id % 2 == 0)
                    await tran.CommitAsync();
                else
                    await tran.RollbackAsync();
            }

            return Ok();
        }

        [Route("GetUsers")]
        [HttpPost]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.OrderByDescending(x => x.Id).Select(x => new UserDto() 
            { 
                Id  =  x.Id,
                Name= x.Name,
                Created = x.Created
            }).ToListAsync();

            return Ok(users);
        }




    }
}
