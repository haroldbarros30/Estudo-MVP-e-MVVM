using System.Collections.Generic;
using EstudoMVP2.Model;
using Xamarin.Forms;
using EstudoMVP2.MVP;
using EstudoMVP2.MVP.Presenters;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace EstudoMVP2
{
    public partial class EstudoMVP2Page : ContentPage
            ,IUsuarioCadastroPassive
    {

        private int indexSelecionado = 0;
        private UsuarioCadastroPresenterPasssiveView presenter = null;

        public EstudoMVP2Page()
        {
            InitializeComponent();
            presenter = new UsuarioCadastroPresenterPasssiveView(this);
            presenter.LoadAllUsuarios();
          
        }

        #region Metodos_da_IUsuarioCadastroPassive


        public int GetIndexSelecionado()
        {
            return indexSelecionado;
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

        public void SetIdUsuarioSelecionado(int value)
        {
            indexSelecionado = value;
        }

        ObservableCollection<Usuario> usuarioLista;

        public void SetListaUsuariosCadastrados(IList<Usuario> usuarios)
        {

            usuarioLista = new ObservableCollection<Usuario>(usuarios);

            listview.ItemsSource = usuarioLista;
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
            indexSelecionado = 0;
        }

        #endregion

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item != null && e.Item is Usuario)
            {
                var usuario = (e.Item as Usuario);
                presenter.ExibirUsuarioSelecionado(usuario);
            }

          

        }
    }
   
}
