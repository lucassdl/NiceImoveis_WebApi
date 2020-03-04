using System.Collections.Generic;

namespace NiceImoveis_WebApi.Domain.Interfaces.Generic
{
    public interface IGeneric<T> where T : class
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(int id);
        List<T> Listar();
    }
}
