using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace YemERP.InfrastructureLayer.Context
{
    public class SevkiyatDbContext:DbContext
    {
        public SevkiyatDbContext(DbContextOptions<SevkiyatDbContext> options):base(options) {}
}
}
