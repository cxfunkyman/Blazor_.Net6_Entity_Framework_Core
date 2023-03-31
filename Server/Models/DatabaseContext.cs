using Blazor_.Net6_Entity_Framework_Core.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_.Net6_Entity_Framework_Core.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("userdetails");
                entity.Property(e => e.Userid)
                    .HasColumnName("userid");
                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);
                entity.Property(e => e.Telephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
/*
    CREATE TABLE [dbo].[userdetails](
    [userid] [int] IDENTITY(1,1) NOT NULL,
    [username] [nvarchar](100) NULL,
    [address] [nvarchar](500) NULL,
    [telephone] [nvarchar](50) NULL,
    [email] [nvarchar](50) NULL,
    CONSTRAINT [PK_userdetails] PRIMARY KEY CLUSTERED
    (
        [userid] ASC
    )
)
 */

