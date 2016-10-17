using EstudoMVP1.Model.Entities;
using EstudoMVP1.MVP.Interfaces;
using EstudoMVP1.MVP.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstudoMVP1.WebForms
{
    public partial class _Default : Page, IUsuarioCadastroPassive
    {

        #region Metodo_da_IUsuarioCadastroPassive

        private const string VIEW_STATE_ID_USUARIO = "ID_USUARIO_SELECIONADO";
        private UsuarioCadastroPresenterPasssiveView _presenter = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new UsuarioCadastroPresenterPasssiveView(this);
        }

        public string GetNome()
        {
            return txtNome.Text;
        }

        public string GetLogin()
        {
            return txtLogin.Text;
        }

        public string GetSenha()
        {
            return txtSenha.Text;
        }

        public void SetIdUsuarioSelecionado(long value)
        {
            ViewState[VIEW_STATE_ID_USUARIO] = value;
        }

        public void SetNome(string value)
        {
            txtNome.Text = value;
        }

        public void SetLogin(string value)
        {
            txtLogin.Text = value;
        }

        public void SetSenha(string value)
        {
            txtSenha.Text = value;
        }


        public void SetListaUsuariosCadastrados(IList<Usuario> usuarios)
        {
            grvUsuarios.DataSource = null;
            grvUsuarios.DataSource = usuarios;
            grvUsuarios.DataBind();
        }

        public void LimparControles()
        {
            txtNome.Text = "";
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        public long GetIdUsuarioSelecionado()
        {
            if (ViewState[VIEW_STATE_ID_USUARIO] != null)
                return Convert.ToInt32(ViewState[VIEW_STATE_ID_USUARIO].ToString());
            else
                return 0;
        }

        #endregion



        #region Metodo_da_View

        protected void grvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idxUsuarioSelecionado = Convert.ToInt32(grvUsuarios.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text);
            SetIdUsuarioSelecionado(idxUsuarioSelecionado);

            if (e.CommandName.Equals("editar"))
                _presenter.ExibirUsuarioSelecionado();
            else
            if (e.CommandName.Equals("deletar"))
                _presenter.Deletar();
        }

        protected void btnSalvar_click(object sender, EventArgs e)
        {
            _presenter.Salvar();
        }

        protected void btnAtualizar_click(object sender, EventArgs e)
        {
            _presenter.Atualizar();
        }

        protected void btnCancelar_click(object sender, EventArgs e)
        {
            SetIdUsuarioSelecionado(0);
            LimparControles();
        }


        #endregion
    }
}