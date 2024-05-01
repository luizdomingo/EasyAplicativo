namespace Easy.Services.Dtos
{
    public class BaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool Habilitado { get; set; }
    }
}
