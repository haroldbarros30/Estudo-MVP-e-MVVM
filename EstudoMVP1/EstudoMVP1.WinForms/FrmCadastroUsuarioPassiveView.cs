//using EstudoMVP1.Model.Entities;
using EstudoMVP1.MVP.Interfaces;
using EstudoMVP1.MVP.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoMVP1.WinForms
{
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
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }

        public void SetIdUsuarioSelecionado(long value)
        {
            IdUsuarioSelecionado = value;
        }

        public void SetListaUsuariosCadastrados(IList<EstudoMVP1.Model.Entities.Usuario> usuarios)
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuarioSelecionado = long.Parse(dgvUsuarios.SelectedRows[0].Cells[0].Value.ToString());
            presenter.ExibirUsuarioSelecionado();
        }

        #endregion
    }
}
