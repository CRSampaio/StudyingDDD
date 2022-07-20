using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Interfaces.Base;

namespace FIGAudioServices.Infra.Interfaces.Files
{
    public interface IAudioAlertsRepository : IBasicRepository<AudioAlert>
    {
        Task<IList<AudioAlert>> GetAllAsync();

        Task<AudioAlert> GetAllByAudioAsync(Audio audio);
    }
}