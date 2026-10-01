using Microsoft.Extensions.Configuration;   
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, IConfiguration configuration)
        {
            _authenticationService = new Lazy<IAuthService>(() =>
                new AuthenticationManager(repositoryManager, configuration));
        }

        public IAuthService AuthenticationService => _authenticationService.Value;
    }
}