using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("user")]
    public class user
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="請輸入帳號")]
        [StringLength(20, ErrorMessage = "輸入長度需小於20字元")]
        public string account { get; set; }

        [Required(ErrorMessage ="請輸入密碼")]
        [StringLength(20,ErrorMessage = "輸入長度需小於20字元")]
        public string password { get; set; }

        public int permission_id { get; set; }

        public string add_user { get; set; }
        
    }
}
