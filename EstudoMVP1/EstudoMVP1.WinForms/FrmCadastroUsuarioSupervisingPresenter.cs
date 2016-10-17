using EstudoMVP1.MVP.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudoMVP1.Model.Entities;
using EstudoMVP1.MVP.Presenters;

namespace EstudoMVP1.WinForms
{
    public partial class FrmCadastroUsuarioSupervisingPresenter : Form, IUsuarioCadastroSupervising
    {
        #region Metodo_da_IUsuarioCadastroSupervising

     

        private long IdUsuarioSelecionado = 0;
        private UsuarioCadastroPresenterSupervising presenter = null;

        public FrmCadastroUsuarioSupervisingPresenter()
        {
            InitializeComponent();
        }

        public Usuario GetUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Id = IdUsuarioSelecionado;
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
           
            return usuario;
        }

        public void LimparControles()
        {
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }

        public void SetListaUsuariosCadastrados(IList<Usuario> usuarios)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Refresh();
        }

        public void SetUsuario(Usuario usuario)
        {
            IdUsuarioSelecionado = usuario.Id;
             txtNome.Text = usuario.Nome;
             txtLogin.Text = usuario.Login;
             txtSenha.Text = usuario.Senha;
        }

        #endregion


           #region Metodos_da_View

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            presenter.Salvar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            presenter.Atualizar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            presenter.Deletar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparControles();
            IdUsuarioSelecionado = 0;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuarioSelecionado = long.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            presenter.ExibirUsuarioSelecionado();
        }

        #endregion

    }
}
