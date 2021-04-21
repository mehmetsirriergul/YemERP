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

        public DbSet<NetsisIsemriTbl> NetsisIsemriTbls { get; set; }
       

    }
}
