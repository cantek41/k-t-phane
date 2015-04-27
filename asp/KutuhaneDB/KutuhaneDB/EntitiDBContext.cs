
namespace KutuhaneDB
{
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Core.EntityClient;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    public partial class EntitiDBContext : DbContext
    {
        public EntitiDBContext()
            : base("name=DefaultConnection") 
        { }
        public virtual DbSet<BOOK> BOOKS { get; set; }
        public virtual DbSet<DEPOSITACTUEL> DEPOSITACTUEL { get; set; }
        public virtual DbSet<DEPOSITARSHIVE> DEPOSITARSHIVE { get; set; }
        public virtual DbSet<DESCRIPTION> DESCRIPTION { get; set; }
        public virtual DbSet<KEYWORD> KEYWORD { get; set; }
        public virtual DbSet<MEMBER> MEMBER { get; set; }
        public virtual DbSet<PUBLISHER> PUBLISHER { get; set; }
        public virtual DbSet<SCHOOL> SCHOOL { get; set; }
        public virtual DbSet<TYPE> TYPE { get; set; }
        public virtual DbSet<WRITER> WRITER { get; set; }

    }
}
