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

      
<!--



<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstudoMVP1.WebForms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>

    
-->

  </asp:Content>



