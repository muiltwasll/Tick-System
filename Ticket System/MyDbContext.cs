using Microsoft.EntityFrameworkCore;
using Ticket_System.Models;


namespace Ticket_System
{
    public class MyDbContext : DbContext
    {
        public DbSet<user> user { get; set; }
        public DbSet<bug_report> bug_report { get; set; }
        public DbSet<bug_report_detail> bug_report_detail { get; set; }
        public DbSet<permission> permission { get; set; }
        public DbSet<require> require { get; set; }
        public DbSet<require_detail> require_detail { get; set; }
        public DbSet<use_case> use_case { get; set; }
        public DbSet<use_case_detail> use_case_detail { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }


    }
}
