//using System;
//using System.Linq;
using System.Collections.Generic;
//using System.Text;
using EstudoMVP2.Model;
using EstudoMVP2.Model.Repository;

namespace EstudoMVP2.MVP.Presenters
{
    public class UsuarioCadastroPresenterPasssiveView
    {
        private IUsuarioCadastroPassive _view = null;

        private UsuarioCadastroPresenterPasssiveView()
        {

        }

        public UsuarioCadastroPresenterPasssiveView(IUsuarioCadastroPassive view)
        {
            this._view = view;
        }

        public void ExibirUsuarioSelecionado()
        {
            Usuario usuario = UsuarioRepository.GetUsuarioById(_view.GetIdUsuarioSelecionado());
            _view.SetLogin(usuario.Login);
            _view.SetNome(usuario.Nome);
            _view.SetSenha(usuario.Senha);
        }

        public void Salvar()
        {
            Usuario usuario = new Usuario();
            usuario.Login = _view.GetLogin();
            usuario.Nome = _view.GetNome();
            usuario.Senha = _view.GetSenha();

            UsuarioRepository.Inserir(usuario);
            LoadAllUsuarios();
            _view.LimparControles();
        }

        public void Atualizar()
        {
            Usuario usuario = new Usuario();
            usuario.Id = _view.GetIdUsuarioSelecionado();
            usuario.Login = _view.GetLogin();
            usuario.Nome = _view.GetNome();
            usuario.Senha = _view.GetSenha();

            UsuarioRepository.Atualizar(usuario);
            LoadAllUsuarios();
            _view.LimparControles();
        }

        public void Deletar()
        {
            UsuarioRepository.Deletar(_view.GetIdUsuarioSelecionado());
            LoadAllUsuarios();
            _view.LimparControles();
        }

        public void LoadAllUsuarios()
        {
            IList<Usuario> usuarios = UsuarioRepository.GetUsuariosCadastrados();
            _view.SetListaUsuariosCadastrados(usuarios);
        }
    }
}
