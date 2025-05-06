using EntityFrameworkCore.Projectables;
using LinqKit;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Api.Entities
{
    public class User
    {
        static readonly string[] types = new string[] { "Male", "Female", "3rd" };

        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; } = string.Empty;

        [Projectable]
        public string FullName => Id + " " + Name;

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
        public string BikeDescription => Bike == null ? "No Bike" : Bike.Description;

        public string BikeDescriptionValue => BikeDescriptionExpr.Invoke(this);

        public static Expression<Func<User, string>> BikeDescriptionExpr =>
            x => x.Bike == null ? "No Bike" : x.Bike.Description;


        [Projectable]
        public double? AverageCapacityExpression => Bags.Average(x => x.Capacity);
        public double AverageCapacityValue => Bags.Count == 0 ? 0 : Bags.Average(x => x.Capacity);

        public static Expression<Func<User, string>> UserFavoriteDescriptionExpr =>
            x => x.Favorite == UserFavorite.Car
                ? x.Car != null
                    ? "Car "+ x.Car.Name
                    : string.Empty
                : x.Bike != null
                    ? "Bike " + x.Bike.Name
                    : string.Empty;


        public string UserFavoriteDescriptionValue => UserFavoriteDescriptionExpr.Invoke(this);

        [Projectable]
        public string UserFavoriteDescription => Favorite == UserFavorite.Car
            ? Car != null
                ? "Car " + Car.Name
                : string.Empty
            : Bike != null
                ? "Bike " + Bike.Name
                : string.Empty;

        public static Expression<Func<User, string>> UserDescriptionExpr =>
            x => "Name: " + x.Name + ", Point: " + x.Point;
        public string UserDescriptionValue => UserDescriptionExpr.Invoke(this);

        [Projectable]
        public string UserDescription => "Name: " + Name + ", Point: " + Point;

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
