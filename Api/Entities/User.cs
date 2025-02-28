using EntityFrameworkCore.Projectables;
using System.Linq.Expressions;

namespace Api.Entities
{
    public class User
    {
        static readonly string[] types = new string[] { "Male", "Female", "3rd" };

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public int Point { get; set; }
        public string Type { get; set; }
        public HashSet<UserBag> Bags { get; set; } = [];

        public UserFavorite Favorite { get; set; }

        public Car Car { get; set; } = null!;
        public int? CarId { get; set; }

        public Bike Bike { get; set; } = null!;
        public int? BikeId { get; set; }

        [Projectable]
        public double? AverageCapacityExpression => Bags.Average(x => x.Capacity);
        public double AverageCapacityValue => Bags.Count == 0 ? 0 : Bags.Average(x => x.Capacity);

        [Projectable]
        public string UserFavoriteDescription => Favorite == UserFavorite.Car 
            ? Car != null 
                ? $"Car {Car.Name}"
                : string.Empty
            : Bike != null
                ? $"Bike {Bike.Name}"
                : string.Empty;

        [Projectable]
        public string UserDescription => $"Name: {Name}, Point: {Point}";

        public User()
        {
            Created = new DateTime(2023, new Random(Guid.NewGuid().GetHashCode()).Next(1, 12), 1);
            Point = new Random(Guid.NewGuid().GetHashCode()).Next(0, 100);
            Type = types[new Random(Guid.NewGuid().GetHashCode()).Next(0, 3)];
        }

        public User(string name) : this()
        {
            Name = name;
        }

    }
}
