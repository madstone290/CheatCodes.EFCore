namespace Api.Dtos
{
    public record UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public int Point { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
