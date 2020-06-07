using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PuyuhAir
{
    public class PesawatContext : DbContext
    {
        public DbSet<Pesawat> Pesawats { get; set; }
        public PesawatContext() : base("penerbangan")
        {

        }
    }
}