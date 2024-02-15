namespace Infrastructure.Data.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}

