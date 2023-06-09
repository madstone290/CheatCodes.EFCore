﻿namespace Api.Data.Entities
{
    public class User
    {
        static readonly string[] types = new string[] { "Male", "Female", "3rd" };

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public int Point { get; set; }
        public string Type { get; set; }
        public HashSet<UserBag> Bags { get; set; } = new HashSet<UserBag>();

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
