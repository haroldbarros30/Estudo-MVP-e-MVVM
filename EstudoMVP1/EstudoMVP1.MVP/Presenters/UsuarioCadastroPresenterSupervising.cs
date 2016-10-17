using EstudoMVP1.Model.Entities;
using EstudoMVP1.Model.Repository;
using EstudoMVP1.MVP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoMVP1.MVP.Presenters
{
    public class UsuarioCadastroPresenterSupervising
    {
        private IUsuarioCadastroSupervising _view = null;

        private UsuarioCadastroPresenterSupervising()
        {
            
        }

        public UsuarioCadastroPresenterSupervising(IUsuarioCadastroSupervising view)
        {
            this._view = view;
        }

        public void ExibirUsuarioSelecionado()
        {
            Usuario usuario = UsuarioRepository.GetUsuarioById(_view.GetUsuario().Id);
            _view.SetUsuario(usuario);
        }

        public void Salvar()
        {
            Usuario usuario = _view.GetUsuario();
            UsuarioRepository.Inserir(usuario);
            LoadAllUsuarios();
            _view.LimparControles();
        }


        public void Atualizar()
        {
            Usuario usuario = _view.GetUsuario();
            UsuarioRepository.Atualizar(usuario);
            LoadAllUsuarios();
            _view.LimparControles();

        }

        public void Deletar()
        {
            UsuarioRepository.Deletar(_view.GetUsuario().Id);
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