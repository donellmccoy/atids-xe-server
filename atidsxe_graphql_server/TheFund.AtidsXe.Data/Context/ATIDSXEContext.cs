using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TheFund.AtidsXe.Data.Entities;

namespace TheFund.AtidsXe.Data.Context
{
    public partial class ATIDSXEContext : DbContext
    {
        public ATIDSXEContext(DbContextOptions<ATIDSXEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TitleEventStatusAssignor> TitleEventStatusAssignor { get; set; }
        public virtual DbSet<SearchNotes> SearchNotes { get; set; }
        public virtual DbSet<SearchStatus> SearchStatus { get; set; }
        public virtual DbSet<SearchType> SearchType { get; set; }
        public virtual DbSet<CertificationRange> CertificationRange { get; set; }
        public virtual DbSet<Search> Search { get; set; }
        public virtual DbSet<ChainOfTitleSearch> ChainOfTitleSearch { get; set; }
        public virtual DbSet<ChainOfTitleNotes> ChainOfTitleNotes { get; set; }
        public virtual DbSet<BranchLocation> BranchLocation { get; set; }
        public virtual DbSet<ChainOfTitle> ChainOfTitle { get; set; }
        public virtual DbSet<ChainOfTitleItem> ChainOfTitleItem { get; set; }
        public virtual DbSet<ChainOfTitleCategory> ChainOfTitleCategory { get; set; }
        public virtual DbSet<ExaminationStatusType> ExaminationStatusType { get; set; }
        public virtual DbSet<FileStatus> FileStatus { get; set; }
        public virtual DbSet<FileReference> FileReference { get; set; }
        public virtual DbSet<GeographicLocale> GeographicLocale { get; set; }
        public virtual DbSet<Worksheet> Worksheet { get; set; }
        public virtual DbSet<WorksheetItem> WorksheetItem { get; set; }
        public virtual DbSet<FileReferenceNotes> FileReferenceNotes { get; set; }
        public virtual DbSet<TitleSearchOrigination> TitleSearchOrigination { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(ATIDSXEContext)));
        }
    }
}
