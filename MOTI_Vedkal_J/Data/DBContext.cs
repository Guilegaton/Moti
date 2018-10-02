using MOTI_Vedkal_J.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AutoCodeSecond
{
    class DBContext : DbContext
    {
        public DBContext() : base("DBContext")
        { }

        public DbSet<Alternative> Alternatives { get; set; }
        public DbSet<Criterion> Criteria { get; set; }
        public DbSet<LPR> LPRs { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Vector> Vectors { get; set; }
    }
}