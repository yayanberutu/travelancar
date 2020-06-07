using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PinguinAir
{
    public class PenerbanganContext : DbContext
    {
        public DbSet<Penerbangan> Penerbangans { get; set; }
        public PenerbanganContext() : base("Penerbangan")
        {
        }
    }
}