using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EstudoMVP2.MVP;
using EstudoMVP2.MVP.Presenters;
using EstudoMVP2.Model;

namespace EstudoMVP2.WinFormsWCE
{

    //parei aqui... testar a classe

    public partial class FrmCadastroUsuarioPassiveView : Form, IUsuarioCadastroPassive
    {
        #region Metodos_da_IUsuarioCadastroPassive

        private long IdUsuarioSelecionado = 0;
        private UsuarioCadastroPresenterPasssiveView presenter = null;

        public FrmCadastroUsuarioPassiveView()
        {
            InitializeComponent();
            presenter = new UsuarioCadastroPresenterPasssiveView(this);
        }

        public long GetIdUsuarioSelecionado()
        {
            return IdUsuarioSelecionado;
        }

        public string GetLogin()
        {
            return txtLogin.Text;
        }

        public string GetNome()
        {
            return txtNome.Text;
        }

        public string GetSenha()
        {
            return txtSenha.Text;
        }

        public void LimparControles()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        public void SetIdUsuarioSelecionado(long value)
        {
            IdUsuarioSelecionado = value;
        }

        public void SetListaUsuariosCadastrados(IList<Usuario> usuarios)
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Refresh();
        }

        public void SetLogin(string value)
        {
            txtLogin.Text = value;
        }

        public void SetNome(string value)
        {
            txtNome.Text = value;
        }

        public void SetSenha(string value)
        {
            txtLogin.Text = value;
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

        private void dgvUsuarios_Click(object sender, EventArgs e)
        {
            IdUsuarioSelecionado = dgvUsuarios.CurrentRowIndex;
            presenter.ExibirUsuarioSelecionado();
        }

        #endregion
    }
}