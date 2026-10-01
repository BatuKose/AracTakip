using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            
        }

      

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();

        public void Save() => _repositoryContext.SaveChanges();
    }
}
