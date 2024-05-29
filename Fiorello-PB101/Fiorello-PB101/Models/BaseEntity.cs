namespace Fiorello_PB101.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDeleted { get; set; } = false;
        public DateTime CreatedDate { get; set; } =DateTime.Now;
    }
}
