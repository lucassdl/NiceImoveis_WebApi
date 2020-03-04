using NiceImoveis_WebApi.Domain.Entities;
using NiceImoveis_WebApi.Infra.Config;
using NiceImoveis_WebApi.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace NiceImoveis_WebApi.Controllers
{
    public class UsuariosController : ApiController
    {
        Usuario usuario = null;

        /// <summary>
        /// Método por responsável por retornar uma Lista de Usuários
        /// </summary>
        /// <returns>JsonResult<List<Usuario>></returns>
        [HttpGet]
        public JsonResult<List<Usuario>> Index()
        {
            List<Usuario> usuarios = null;

            using (var banco = new Context())
            {
                usuarios = banco.Usuarios.ToList();
            }

            return Json(usuarios);
        }

        /// <summary>
        /// Método responsável por retornar um Usuário
        /// </summary>
        /// <param name="id"></param>
        /// <returns>JsonResult<Usuario></returns>
        [HttpPost]
        public JsonResult<Usuario> BuscarUsuario(int id)
        {
            using (var banco = new Context())
            {
                usuario = banco.Usuarios.Find(id);
            }

            return Json(usuario);
        }

        /// <summary>
        /// Método responsável por cadastrar um novo Usuário
        /// </summary>
        /// <param name="usuarioModel"></param>
        /// <returns>JsonResult<Usuario></returns>
        [HttpPost]
        public JsonResult<Usuario> CadastrarUsuario(UsuarioModel usuarioModel)
        {
            var usuario = new Usuario()
            {
                NomeDoUsuario = usuarioModel.NomeDoUsuario,
                EmailDoUsuario = usuarioModel.EmailDoUsuario,
                SenhaDoUsuario = usuarioModel.SenhaDoEmail
            };

            using (var banco = new Context())
            {
                banco.Usuarios.Add(usuario);
                banco.SaveChanges();
            }

            return Json(usuario);
        }

        /// <summary>
        /// Método responsável por editar um Usuário
        /// </summary>
        /// <param name="usuarioModel"></param>
        /// <returns>JsonResult<Usuario></returns>
        [HttpPost]
        public JsonResult<Usuario> EditarUsuario(UsuarioModel usuarioModel)
        {
            using (var banco = new Context())
            {
                banco.Usuarios.Find(usuarioModel.Id);

                usuario.NomeDoUsuario = usuarioModel.NomeDoUsuario;
                usuario.EmailDoUsuario = usuarioModel.EmailDoUsuario;
                usuario.SenhaDoUsuario = usuarioModel.SenhaDoEmail;

                banco.Entry<Usuario>(usuario).State = EntityState.Modified;
                banco.SaveChanges();
            }

            return Json(usuario);
        }

        /// <summary>
        /// Método responsável por excluir um Usuário
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public string ExcluirUsuario(int id)
        {
            using (var banco = new Context())
            {
                usuario = banco.Usuarios.Find(id);

                banco.Usuarios.Remove(usuario);
                banco.SaveChanges();
            }

            return "Usuário Removido com Sucesso";
        }
        
    }
}
