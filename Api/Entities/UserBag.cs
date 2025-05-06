using EntityFrameworkCore.Projectables;

namespace Api.Entities
{
    public class UserBag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? OwnerId { get; set; }
        public User Owner { get; set; } = null!;
        public int Capacity { get; set; } = 12;

        [Projectable]
        public string Description => "Name: " + Name + ", Capacity: " + Capacity;
    }
}
