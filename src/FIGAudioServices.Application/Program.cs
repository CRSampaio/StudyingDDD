using FIGAudioServices.Entities.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FIGAudioServices.Application
{
    public class Program
    {
        public static void Main()
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
                        options.UseInMemoryDatabase("Testing");
                    });
                })
                .Build();

            using (host)
            {
                Console.WriteLine("Iniciando aplicação");

                host.StopAsync().Start();
                Console.WriteLine("Finalizando aplicação");
            }
        }
    }
}