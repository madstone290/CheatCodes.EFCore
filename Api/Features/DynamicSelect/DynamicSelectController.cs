using Api.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text;
using System.Text.Json;
using System.Linq.Dynamic.Core;
using System.Reflection;
using Api.Features.DynamicSelect.Expressions;

namespace Api.Features.DynamicSelect
{
    [ApiController]
    [Route("[controller]")]
    public class DynamicSelectController : ControllerBase
    {
        /**
         * System.Linq.Dynamic.Core를 이용한 동적 쿼리 생성시 전용 문법이 필요하다.
         * Linq: .Select(x=> new { Name = x.OldName, ....} 
         * Linq.Dynamic: .Select("new ( OldName AS Name, ... }
         * 
         * Linq.Dynamic에서 반환되는 객체에는 인덱스를 위한 속성(타입: DynamicClass, 이름: Item)이 존재한다.
         * Item 속성은 이는 실제 데이터와 관련이 없으므로 제거한다.
         * 쿼리생성시 Item을 직접적으로 사용할 경우 이름 충돌이 발생하므로 사용하지 않는다.
         * */
        private readonly ApplicationDbContext _context;

        public DynamicSelectController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("GetReceiptsUsingLinqDynamic")]
        [HttpGet]
        public IActionResult GetReceiptsUsingLinqDynamic()
        {
            // Item 속성을 바로 쿼리할 수 없다.
            var receipts = _context.Receipts.Select(@"new (Id, Item AS Item_)").ToDynamicList();
            return Ok(receipts);
        }

        [HttpGet]
        [Route("GetPivotUsersUsingLinqDynamic")]
        public IActionResult GetUsingLinqDynamic([FromQuery] int lastMonth = 12)
        {
            var range = Enumerable.Range(1, lastMonth);
            string selectText = "new (Key AS Type";
            for (int month = 1; month <= lastMonth; month++)
            {
                selectText += ", ";
                selectText += $"Count(x => x.Month == {month}) AS M{month}";
            }
            selectText += ")";

            for (int i = 1; i <= lastMonth; i++)
            {

            }
            var users = _context.Users.AsQueryable().Where(x => x.Type != null)
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Month = x.Created.Month,
                    Point = x.Point,
                    Type = x.Type
                })
                .GroupBy(x => x.Type)
                .Select(selectText)
                .ToDynamicList();

            IEnumerable<string> props = users.Any() ? 
                ((object)users.First()).GetType().GetProperties().Where(x => x.DeclaringType != typeof(DynamicClass)).Select(p => p.Name) 
                : Enumerable.Empty<string>();
            var dynamicResult = new
            {
                Properties = props.ToList(),
                Data = users
            };
            return Ok(dynamicResult);
        }


        [HttpGet]
        [Route("GetUsersUsingExpression")]
        public IActionResult GetUsersUsingExpression()
        {
            var exp = new ExpressionFactory().BuildExpFromStaticTypeToDynamicType();
            var users = _context.Users
                .Select(exp)
                .ToList();

            
            IEnumerable<string> props = users.Any() 
                ? ((object)users.First()).GetType().GetFields().Select(f=> f.Name)
                : Enumerable.Empty<string>();
            var dynamicResult = new
            {
                Properties = props.ToList(),
                Data = users
            };
            return Ok(dynamicResult);
        }



    }
}
