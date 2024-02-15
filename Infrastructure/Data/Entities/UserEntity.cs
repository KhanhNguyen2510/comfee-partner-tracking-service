namespace Infrastructure.Data.Entities
{
    public class UserEntity : BaseEntity<int>
    {
        /// <summary>
        /// Họ 
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Tên người dùng 
        /// </summary>
        /// <remarks>
        /// (Lastname + FirstName) lấy các kí tự đầu của các khoảng cách  
        /// </remarks>
        public string User { get; set; }

        /// <summary>
        /// Hình ảnh
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}

