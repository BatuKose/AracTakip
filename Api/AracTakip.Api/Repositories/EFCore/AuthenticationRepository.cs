
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class AuthenticationRepository: IAuthenticationRepository
    {
        private readonly RepositoryContext _repositoryContext;
        public AuthenticationRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public async Task<kullanicilar?>KullaniciyiBulAsync(string mail)
        {
            return await _repositoryContext.Kullanicilar.SingleOrDefaultAsync(k => k.Email==mail);
        }
    }
}
