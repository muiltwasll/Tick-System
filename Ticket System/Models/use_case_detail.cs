using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("use_case_detail")]
    public class use_case_detail
{
        [Key]
        public int id { get; set; }

        public int use_case_id { get; set; }

        public string describe { get; set; }

        public string add_user { get; set; }

        public string edit_user { get; set; }
    }
}
