using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ticket_System.Models
{
    [Table("permission")]
    public class permission
{
        [Key]
        public int id { get; set; }

        public string name { get; set; }
    }
}
