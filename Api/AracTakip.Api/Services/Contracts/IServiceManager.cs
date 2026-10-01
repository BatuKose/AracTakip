namespace Services.Contracts
{
    public interface IServiceManager
    {
        IAuthService AuthenticationService { get; }
    }
}
