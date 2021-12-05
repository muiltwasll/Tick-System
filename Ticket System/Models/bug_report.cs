using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("bug_report")]
    public class bug_report
{
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public int state { get; set; }

        public int priority { get; set; }

        public string finish { get; set; }

        public string add_user { get; set; }

        public string edit_user { get; set; }
    }
}
