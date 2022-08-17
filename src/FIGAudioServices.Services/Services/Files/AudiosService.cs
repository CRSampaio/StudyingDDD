using FIGAudioServices.Entities.Files;
using FIGAudioServices.Infra.Interfaces.Files;
using FIGAudioServices.Services.Interfaces.Files;

namespace FIGAudioServices.Services.Services.Files
{
    public class AudiosService : IAudiosService
    {
        private readonly IAudiosRepository AudiosRepository;

        public AudiosService(IAudiosRepository audiosRepository)
        {
            AudiosRepository = audiosRepository;
        }

        public async Task CreateAudiosAsync()
        {
            List<Audio> audios = new List<Audio>()
            {
                new Audio(){Id = 1, Filename = "First"},
                new Audio(){Id = 2, Filename = "Second"},
                new Audio(){Id = 3, Filename = "Third"},
                new Audio(){Id = 4, Filename = "Fourth"},
                new Audio(){Id = 5, Filename = "Fiveth"}
            };

            foreach (var audio in audios)
            {
                await AudiosRepository.InsertAsync(audio);
            }
        }
    }
}