using Repositories.Contracts;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAuthenticationRepository> _AuthenticationRepository;

        

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _AuthenticationRepository=new Lazy<IAuthenticationRepository>(() => new AuthenticationRepository(_repositoryContext));


        }

      

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();

        public void Save() => _repositoryContext.SaveChanges();
        public IAuthenticationRepository AuthenticationRepository => _AuthenticationRepository.Value;

    }
}
