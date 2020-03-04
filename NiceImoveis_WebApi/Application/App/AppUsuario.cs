using NiceImoveis_WebApi.Application.Interfaces;
using NiceImoveis_WebApi.Domain.Entities;
using NiceImoveis_WebApi.Domain.Interfaces;
using System.Collections.Generic;

namespace NiceImoveis_WebApi.Application.App
{
    public class AppUsuario : IAppUsuario
    {
        private readonly IUsuario _usuario;

        public AppUsuario(IUsuario usuario)
        {
            _usuario = usuario;
        }

        public void Adicionar(Usuario entidade)
        {
            _usuario.Adicionar(entidade);
        }

        public void Atualizar(Usuario entidade)
        {
            _usuario.Atualizar(entidade);
        }

        public void Excluir(int id)
        {
            _usuario.Excluir(id);
        }

        public List<Usuario> Listar()
        {
            return _usuario.Listar();
        }
    }
}
