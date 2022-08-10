using FIGAudioServices.Entities.Files;
using Microsoft.EntityFrameworkCore;

namespace FIGAudioServices.Infra.Context
{
    public class FIGAudioServicesDbContext : DbContext
    {
        public FIGAudioServicesDbContext(DbContextOptions<FIGAudioServicesDbContext> options) : base(options)
        {            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Audio>? Audios { get; set; }
        public DbSet<AudioAlert>? AudioAlerts { get; set; }
    }
}