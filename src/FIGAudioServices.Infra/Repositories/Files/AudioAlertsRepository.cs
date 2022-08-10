using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Context;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FIGAudioServices.Infra.Repositories.Files
{
    public class AudioAlertsRepository : BasicRepository<AudioAlert>, IAudioAlertsRepository
    {
        public AudioAlertsRepository(FIGAudioServicesDbContext context) : base(context)
        {
        }

        public async Task<IList<AudioAlert>> GetAllAsync()
        {
            return await Context.AudioAlerts!.ToListAsync();
        }

        public async Task<AudioAlert> GetAllAudioAlertsByAudioIdAsync(int id)
        {
            return await Context.AudioAlerts!.FirstAsync(x => x.Audio.Id == id);
        }
    }
}