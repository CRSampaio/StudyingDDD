using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Context;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Infra.Repositories.Base;

namespace FIGAudioServices.Infra.Repositories.Files
{
    public class AudioAlertsRepository : BasicRepository<AudioAlert>, IAudioAlertsRepository
    {
        private readonly FIGAudioServicesDbContext Context;
        
        public AudioAlertsRepository(FIGAudioServicesDbContext context)
        {
            Context = context;
        }

        public async Task<IList<AudioAlert>> GetAllAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task<AudioAlert> GetAllByAudioAsync(Audio audio)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}