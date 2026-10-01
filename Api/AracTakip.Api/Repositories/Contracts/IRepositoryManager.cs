namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        Task SaveAsync();
        void Save();
        IAuthenticationRepository AuthenticationRepository { get; } 
    }
}
