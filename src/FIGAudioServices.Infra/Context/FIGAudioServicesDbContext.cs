using FIGAudioServices.Entities.Files;
using Microsoft.EntityFrameworkCore;

namespace FIGAudioServices.Infra.Context
{
    public class FIGAudioServicesDbContext : DbContext
    {
        public FIGAudioServicesDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Audio>? Audios { get; set; }
        public DbSet<AudioAlert>? AudioAlerts { get; set; }
    }
}