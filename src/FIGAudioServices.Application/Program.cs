using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FIGAudioServices.Application
{
    public class Program
    {
        public static async Task Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddTransient<FIGAudioServices.Infra.Interfaces.Files.IAudiosRepository, FIGAudioServices.Infra.Repositories.Files.AudiosRepository>();
                    services.AddTransient<FIGAudioServices.Infra.Interfaces.Files.IAudioAlertsRepository, FIGAudioServices.Infra.Repositories.Files.AudioAlertsRepository>();
                    services.AddTransient<FIGAudioServices.Services.Interfaces.Files.IAudiosService, FIGAudioServices.Services.Services.Files.AudiosService>();
                    services.AddTransient<FIGAudioServices.Services.Interfaces.Files.IAudioAlertsService, FIGAudioServices.Services.Services.Files.AudioAlertsService>();
                    services.AddDbContext<FIGAudioServices.Infra.Context.FIGAudioServicesDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("FIGAudioService");
                    });
                })
                .Build();

            using (host)
            {
                Console.WriteLine("Starting application");

                Console.WriteLine("Creating audios");

                await host.Services.GetService<FIGAudioServices.Services.Interfaces.Files.IAudiosService>()!.CreateAudiosAsync();

                Console.WriteLine("Audios created");

                var audios = await host.Services.GetService<FIGAudioServices.Infra.Interfaces.Files.IAudiosRepository>()!.GetAllAsync();
                
                foreach (var audio in audios)
                {
                    Console.WriteLine($"{nameof(FIGAudioServices.Entities.Files.Audio.Id)}: {audio.Id}, {nameof(FIGAudioServices.Entities.Files.Audio.Filename)}: {audio.Filename}");
                }

                Console.WriteLine("Exiting application");
                Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}