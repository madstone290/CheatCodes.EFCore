using Api.Data;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Api.Features.Projectables
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectablesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ProjectablesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Get1")]
        public IActionResult Get1()
        {
            var users = _dbContext.Users
                .Where(x=> x.FullName.Contains("abc") || x.UserDescription.Contains("bbb"))
                .Select(x => new
                {
                    Description = x.UserDescription,
                    FavoriteDescription = x.UserFavoriteDescription,
                    AverageCapacity = x.AverageCapacityExpression ?? 0
                })
                .ToArray();
            return Ok(users);
        }

        [HttpGet("Get2")]
        public IActionResult Get2()
        {
            var users = _dbContext.Users
                .Where(x=> x.BikeDescription.Contains("abc"))
                .Select(x => new
                {
                    Bike = x.BikeDescription
                })
                .ToArray();
            return Ok(users);
        }
    }
}
