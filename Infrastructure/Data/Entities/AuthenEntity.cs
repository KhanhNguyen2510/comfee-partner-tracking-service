namespace Infrastructure.Data.Entities
{
    public class AuthenEntity : BaseEntity<int>
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string RefeshToken { get; set; }
        public string SaltToken { get; set; }
        public string Token { get; set; }
        public bool IsLogin { get; set; } = false;
    }
}

