//using System;
//using System.Linq;
using System.Collections.Generic;
//using System.Text;

namespace EstudoMVP2.Model.Repository
{
    public static class UsuarioRepository
    {
        private static long ultimoId = 0;
        private static List<Usuario> usuariosCadastrados = new List<Usuario>();

        public static void Inserir(Usuario usuario)
        {
            ultimoId++;

            usuario.Id = ultimoId;
            usuariosCadastrados.Add(usuario);
        }

        public static void Atualizar(Usuario usuario)
        {
            Deletar(usuario.Id);
            usuariosCadastrados.Add(usuario);
        }

        public static void Deletar(long IdUsuario)
        {
            int idxUsuarioLocalizado = usuariosCadastrados.FindIndex(x => x.Id.Equals(IdUsuario));

            usuariosCadastrados.RemoveAt(idxUsuarioLocalizado);
        }

        public static List<Usuario> GetUsuariosCadastrados()
        {

            return usuariosCadastrados;
        }

        public static Usuario GetUsuarioById(long IdUsuario)
        {
            return usuariosCadastrados.Find(x => x.Id.Equals(IdUsuario));
        }
    }

}
