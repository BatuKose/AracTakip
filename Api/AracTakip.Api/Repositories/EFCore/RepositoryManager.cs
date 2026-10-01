using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        // private readonly Lazy<IXRepository> _xRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            // _xRepository = new Lazy<IXRepository>(() => new XRepository(_repositoryContext));
        }

        // public IXRepository X => _xRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();

        public void Save() => _repositoryContext.SaveChanges();
    }
}
