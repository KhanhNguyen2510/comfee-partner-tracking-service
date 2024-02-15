using Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.EFs
{
	public partial class CPTSDbSet : CPTSDbContext
    {
        public DbSet<AuthenEntity> Authen { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}