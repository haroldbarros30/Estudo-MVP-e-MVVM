using EstudoMVP1.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMVP1.MVP.Interfaces
{
    public interface IUsuarioCadastroSupervising
    {
        Usuario GetUsuario();

        void SetUsuario(Usuario usuario);

        void SetListaUsuariosCadastrados(IList<Usuario> usuarios);

        void LimparControles();

    }
}
