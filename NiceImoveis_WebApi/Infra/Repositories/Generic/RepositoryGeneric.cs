using NiceImoveis_WebApi.Domain.Interfaces.Generic;
using NiceImoveis_WebApi.Infra.Config;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NiceImoveis_WebApi.Infra.Repositories.Generic
{
    public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    {
        public void Adicionar(T entidade)
        {
            using (var banco = new Context())
            {
                banco.Set<T>().Add(entidade);
                banco.SaveChanges();
            }   
        }

        public void Atualizar(T entidade)
        {
            using (var banco = new Context())
            {
                banco.Set<T>().Remove(entidade);
                banco.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var banco = new Context())
            {
                var objeto = banco.Set<T>().Find(id);

                banco.Set<T>().Remove(objeto);
                banco.SaveChanges();
            }
        }

        public List<T> Listar()
        {
            using (var banco = new Context())
            {
                return banco.Set<T>().ToList();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
