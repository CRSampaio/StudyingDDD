using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Context;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Infra.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace FIGAudioServices.Infra.Repositories.Files
{
    public class AudiosRepository : BasicRepository<Audio>, IAudiosRepository
    {
        public AudiosRepository(FIGAudioServicesDbContext context) : base(context)
        {
        }

        public async Task<IList<Audio>> GetAllAsync()
        {
            return await Context.Audios!.ToListAsync();
        }

        public async Task<Audio> GetByFilenameAsync(string filename)
        {
            return await Context.Audios!.FirstAsync(x => x!.Filename!.Contains(filename));
        }
    }
}