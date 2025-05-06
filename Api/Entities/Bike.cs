using EntityFrameworkCore.Projectables;
using System.Linq.Expressions;

namespace Api.Entities
{
    public class Bike
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }

        [Projectable]
        public string Description => "Name: " + Name + ", Model: " + Model;

        public static Expression<Func<Bike, string>> DescriptionExpr =>
            x => "Name: " + x.Name + ", Model: " + x.Model;
    }
}
