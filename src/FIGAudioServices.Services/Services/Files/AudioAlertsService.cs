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
                new AudioAlert(){Id = 1, Description = "Alerta do Primeiro"},
                new AudioAlert(){Id = 2, Description = "Alerta do Segundo"},
                new AudioAlert(){Id = 3, Description = "Alerta do Terceiro"},
                new AudioAlert(){Id = 4, Description = "Alerta do Quarto"},
                new AudioAlert(){Id = 5, Description = "Alerta do Quinto"}
            };

            foreach (var audioAlert in audioAlerts)
            {
                audioAlert.Audio = audios.FirstOrDefault(x => x.Id == audioAlert.Id)!;
                await AudioAlertsRepository.InsertAsync(audioAlert);
            }
        }
    }
}