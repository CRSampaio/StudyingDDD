using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Services.Interfaces.Files;

namespace FIGAudioServices.Services.Services.Files
{
    public class AudioAlertsService : IAudioAlertsService
    {
        private readonly IAudioAlertsRepository AudioAlertsRepository;

        private readonly IAudiosRepository AudiosRepository;

        public AudioAlertsService(IAudioAlertsRepository audioAlertsRepository, IAudiosRepository audiosRepository)
        {
            AudioAlertsRepository = audioAlertsRepository;
            AudiosRepository = audiosRepository;
        }

        public async Task CreateAudioAlertsAsync()
        {
            var audios = await AudiosRepository.GetAllAsync();

            List<AudioAlert> audioAlerts = new List<AudioAlert>()
            {
                new AudioAlert(){Id = 1, Description = "First Alert"},
                new AudioAlert(){Id = 2, Description = "Second Alert"},
                new AudioAlert(){Id = 3, Description = "Third Alert"},
                new AudioAlert(){Id = 4, Description = "Fourth Alert"},
                new AudioAlert(){Id = 5, Description = "Fiveth Alert"}
            };

            foreach (var audioAlert in audioAlerts)
            {
                audioAlert.Audio = audios.FirstOrDefault(x => x.Id == audioAlert.Id)!;
                await AudioAlertsRepository.InsertAsync(audioAlert);
            }
        }
    }
}