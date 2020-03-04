using NiceImoveis_WebApi.Domain.Entities;
using NiceImoveis_WebApi.Domain.Interfaces;
using NiceImoveis_WebApi.Infra.Repositories.Generic;

namespace NiceImoveis_WebApi.Infra.Repositories
{
    public class RepositorioUsuario:RepositoryGeneric<Usuario>, IUsuario
    {
    }
}
