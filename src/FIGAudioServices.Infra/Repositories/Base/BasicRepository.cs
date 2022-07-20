using FIGAudioServices.Infra.Interfaces.Base;

namespace FIGAudioServices.Infra.Repositories.Base
{
    public class BasicRepository<T> : IBasicRepository<T> where T : class
    {
        public async Task DeleteAsync(T entity)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task InsertAsync(T entity)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}