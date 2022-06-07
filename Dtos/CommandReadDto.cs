namespace minimal_api.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string? Howto { get; set; }
        public string? Platform { get; set; }
        public string? CommandLine { get; set; }
    }
}