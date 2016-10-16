using EstudoMVP1.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMVP1.MVP.Interfaces
{

    public interface IUsuarioCadastroPassive
    {
        long GetIdUsuarioSelecionado();

        string GetNome();

        string GetLogin();

        string GetSenha();

        void SetIdUsuarioSelecionado(long value);

        void SetNome(string value);

        void SetLogin(string value);

        void SetSenha(string value);

        void SetListaUsuariosCadastrados(IList<Usuario> usuarios);

        void LimparControles();
    }

}
