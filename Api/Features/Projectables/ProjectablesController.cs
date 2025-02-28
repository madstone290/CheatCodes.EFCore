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


        /// <summary>
        /// 계산된 속성을 포함한 사용자 정보를 반환한다.
        /// </summary>
        /// <returns></returns>
        [HttpGet("IQueryableUsers")]
        public IActionResult IQueryableUsers()
        {
            var users = _dbContext.Users
                .Include(x => x.Car)
                .Include(x => x.Bike)
                .Include(x=> x.Bags)
                .Select(x=> new
            {
                Description = x.UserDescription,
                FavoriteDescription = x.UserFavoriteDescription,
                AverageCapacity = x.AverageCapacityExpression ?? 0
            })
                .ToArray();
            return Ok(users);
        }

        [HttpGet("IEnumerableUsers")]
        public IActionResult IEnumerableUsers()
        {
            var users = _dbContext.Users
                .Include(x => x.Car)
                .Include(x => x.Bike)
                .Include(x => x.Bags)
                .AsEnumerable()
                .Select(x => new
                {
                    Description = x.UserDescription,
                    FavoriteDescription = x.UserFavoriteDescription,
                    AverageCapacity = x.AverageCapacityValue
                })
                .ToArray();
            return Ok(users);
        }
    }
}
