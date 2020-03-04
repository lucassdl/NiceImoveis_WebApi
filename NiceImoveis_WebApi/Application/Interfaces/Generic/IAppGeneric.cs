using System.Collections.Generic;

namespace NiceImoveis_WebApi.Application.Interfaces.Generic
{
    public interface IAppGeneric<T> where T : class
    {
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(int id);
        List<T> Listar();
    }
}
