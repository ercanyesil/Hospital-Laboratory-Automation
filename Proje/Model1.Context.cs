//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hastanelerEntities : DbContext
    {
        public hastanelerEntities()
            : base("name=hastanelerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doktorlar> Doktorlar { get; set; }
        public virtual DbSet<Hastalar> Hastalar { get; set; }
        public virtual DbSet<HastaneAdi> HastaneAdi { get; set; }
        public virtual DbSet<İller> İller { get; set; }
        public virtual DbSet<Kan_grubu> Kan_grubu { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<RaporAd> RaporAd { get; set; }
        public virtual DbSet<Tahlil_adi> Tahlil_adi { get; set; }
    }
}
