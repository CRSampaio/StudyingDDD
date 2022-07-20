namespace FIGAudioServices.Infra.Interfaces.Base
{
    public interface IBasicRepository<T> where T : class
    {
        Task InsertAsync(T entity);

        Task UpdateAsync(T entity);
        
        Task DeleteAsync(T entity);
    }
}
