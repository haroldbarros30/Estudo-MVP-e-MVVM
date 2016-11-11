//using System;
//using System.Linq;
using System.Collections.Generic;
using EstudoMVP2.Model;
//using System.Text;

namespace EstudoMVP2.MVP
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
