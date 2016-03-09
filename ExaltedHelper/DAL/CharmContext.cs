using System;
using ExaltedHelper.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ExaltedHelper.DAL
{
    public class CharmContext : DbContext
    {
        public CharmContext()
            : base("CharmContext")
        {
        }
        public DbSet<CharmDataModel> CharmModel { get; set; }
        public DbSet<AttributeCategoryDataModel> AttributeCategoryModel { get; set; }
        public DbSet<AttributeDataModel> AttributeModel { get; set; }
        public DbSet<ExaltedTypeDataModel> ExaltedTypeModel { get; set; }
        public DbSet<SkillDataModel> SkillModel { get; set; }
        public DbSet<CastesDataModel> CastesModel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<ExaltedHelper.Models.CharmViewModel> CharmViewModels { get; set; }
    }
}