using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Context;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Infra.Repositories.Base;

namespace FIGAudioServices.Infra.Repositories.Files
{
    public class AudiosRepository : BasicRepository<Audio>, IAudiosRepository
    {
        private readonly FIGAudioServicesDbContext Context;

        public AudiosRepository(FIGAudioServicesDbContext context)
        {
            Context = context;
        }

        public async Task<IList<Audio>> GetAllAsync()
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task<Audio> GetByFilenameAsync(string filename)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}