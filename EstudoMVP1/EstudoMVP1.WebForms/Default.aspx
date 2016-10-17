  <%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstudoMVP1.WebForms._Default" %>
 

  <asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
  <asp:GridView runat="server" ID="grvUsuarios" DataKeyNames="Id"
  onrowcommand="grvUsuarios_RowCommand" >
  <Columns>
  <asp:ButtonField CommandName="editar" Text="Editar" />
  <asp:ButtonField CommandName="deletar" Text="Deletar" />
  </Columns>
  </asp:GridView>
  <hr />
  <asp:Label ID="Label1" runat="server">Nome</asp:Label>
  <asp:TextBox ID="txtNome" runat="server"></asp:TextBox><br />
 
  <asp:Label ID="Label2" runat="server">Login</asp:Label>
  <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox><br />
 
  <asp:Label ID="Label3" runat="server">Senha</asp:Label>
  <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox><br />
 
  <hr />
  <asp:Button runat="server" ID="btnSalvar" OnClick="btnSalvar_click" Text="Salvar Novo"/>
  <asp:Button runat="server" ID="btnAtualizar" OnClick="btnAtualizar_click" Text="Atualizar"/>
  <asp:Button runat="server" ID="btnCancelar" OnClick="btnCancelar_click" Text="Cancelar"/>

      

  </asp:Content>



