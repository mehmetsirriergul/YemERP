using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YemERP.WepApi.Models.Concrete;

namespace YemERP.WepApi.Models.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<NetsisIsemriTbl>(b =>
            {
                // Primary key
                b.HasKey(uc => uc.INCKEYNO);

                // Maps to the AspNetUserClaims table
                b.ToTable("NetsisIsemriTbl");
            });
            //Configure domain classes using modelBuilder here   

           
    }
            public DbSet<NetsisIsemriTbl> NetsisIsemriTbls { get; set; }
       

    }
}
