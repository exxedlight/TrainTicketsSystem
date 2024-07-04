using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace TrainTicketsWithDB.Entities
{
    public class TrainDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<WayEntity> Ways { get; set; }
        public DbSet<WaypointEntity> Waypoints { get; set; }
        public DbSet<TicketEntity> Tickets { get; set; }
        public DbSet<DateEntity> Dates { get; set; }
        public DbSet<CodeEntity> Codes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\zDocs\C_Sharp\WithDB\TrainTicketsWithDB\DB\TrainDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}