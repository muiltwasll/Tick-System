using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("require_detail")]
    public class require_detail
    {
        [Key]
        public int id { get; set; }

        public int require_id { get; set; }

        public string describe {get;set;}

        public string finish { get; set; }

        public string add_user { get; set; }

        public string edit_user { get; set; }
    }
}
