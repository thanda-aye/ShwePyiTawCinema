using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShwePyiTawCinema.Models.ViewModel;

#nullable disable

namespace ShwePyiTawCinema.Models
{
    public partial class ShwePyiTawCinemaContext : DbContext
    {
        public ShwePyiTawCinemaContext()
        {
        }

        public ShwePyiTawCinemaContext(DbContextOptions<ShwePyiTawCinemaContext> options)
            : base(options)
        {
        }

        public DbSet<ClassTbl> ClassTbl { get; set; }
        public DbSet<ClassType> ClassTypeTbl { get; set; }
        public DbSet<IncomesTbl> IncomesTbl { get; set; }
        public DbSet<ExpensesTbl> ExpenseTbl { get; set; }
        public DbSet<MovieTbl> MovieTbl { get; set; }
        public DbSet<MovieTimeTbl> MovieTimeTbl { get; set; }
        public DbSet<TicketTbl> TicketTbl { get; set; }
        public DbSet<TicketPriceTbl> TicketPriceTbl { get; set; }
        public DbSet<SignUpTbl> SignupTbl { get; set; }
        public DbSet<RoleTbl> RoleTbl { get; set; }
        public DbSet<UserTbl> UserTbl { get; set; }            
                 
    }
}
