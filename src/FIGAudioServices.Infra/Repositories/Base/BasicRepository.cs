using FIGAudioServices.Infra.Context;
using FIGAudioServices.Infra.Interfaces.Base;

namespace FIGAudioServices.Infra.Repositories.Base
{
    public class BasicRepository<T> : IBasicRepository<T> where T : class
    {
        protected readonly FIGAudioServicesDbContext Context;

        public BasicRepository(FIGAudioServicesDbContext context)
        {
            Context = context;
        }

        public async Task DeleteAsync(T entity)
        {
            Context.Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task InsertAsync(T entity)
        {
            Context.Add(entity);
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
        }
    }
}