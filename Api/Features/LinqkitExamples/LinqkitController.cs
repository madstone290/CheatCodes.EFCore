using Api.Data;
using Api.Entities;
using LinqKit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Api.Features.LinqkitExamples
{
    [ApiController]
    [Route("[controller]")]
    public class LinqkitController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public LinqkitController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("Get1")]
        public IActionResult Get1()
        {
            var predicate = PredicateBuilder.New<Entities.User>()
                .And(x => Entities.User.UserDescriptionExpr.Invoke(x).StartsWith("abc"))
                .Or(x => Entities.User.UserFavoriteDescriptionExpr.Invoke(x).Contains("bbb"));

            var p2 = PredicateBuilder.New<User>();
            var keywords = new string[] { "ab", "bc", "cd" };
            for (int i = 0; i < keywords.Length; i++)
            {
                string key = keywords[i];
                p2 = p2.Or(x => x.Name.Contains(key));
            }

            var p = PredicateBuilder.New<User>();

            p = p.Or(x => x.Name.Contains("99999"));
            p = p.Or(x => x.Name.Contains("888888"));



            var users = _dbContext.Users
                .AsExpandable()
                .Where(p)
                .Where(p2)
                .ToArray();
            return Ok(users);
        }


        [HttpGet("Get2")]
        public IActionResult Get()
        {
            var users = _dbContext.Users
                .AsExpandable()
                .Where(x => Entities.User.BikeDescriptionExpr.Invoke(x).Contains("abc"))
                .Select(x => new
                {
                    Bike = Entities.User.BikeDescriptionExpr.Invoke(x),
                    //Bike = x.Bike.Description
                })
                .ToList();


            return Ok(users);
        }
    }
}
