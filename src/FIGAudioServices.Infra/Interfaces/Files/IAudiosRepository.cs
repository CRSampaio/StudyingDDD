using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Interfaces.Base;

namespace FIGAudioServices.Infra.Interfaces.Files
{
    public interface IAudiosRepository : IBasicRepository<Audio>
    {
        Task<IList<Audio>> GetAllAsync();

        Task<Audio> GetByFilenameAsync(string filename);
    }
}