namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        // Repository property'leri buraya (örn: IXRepository X { get; })

        Task SaveAsync();
        void Save();
    }
}
