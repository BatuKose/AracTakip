using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        // private readonly Lazy<IXService> _xService;

        public ServiceManager(IRepositoryManager repositoryManager, IConfiguration configuration)
        {
            // _xService = new Lazy<IXService>(() => new XManager(repositoryManager));
        }

        // public IXService XService => _xService.Value;
    }
}
