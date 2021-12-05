using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("bug_report_detail")]
    public class bug_report_detail
{
        [Key]
        public int id { get; set; }

        public int bug_report_id { get; set; }

        public string describe { get; set; }

        public string add_user { get; set; }

        public string edit_user { get; set; }
    }
}
