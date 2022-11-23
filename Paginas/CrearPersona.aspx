<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CrearPersona.aspx.cs" Inherits="CrudApp.Paginas.CrearPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Crear Persona
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <br />
    <div class="mx-auto" style="width: 250px">
        <asp:Label runat="server" CssClass="h2" ID="lbltitulo">Nueva Persona</asp:Label>
    </div>
        <br />
    <form runat="server" class="h-100 d-flex align-items-center justify-content-center">
        <div>
            <div class="mb-3">
                <label class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="tbnombre"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Apellido</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="tbapellido"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Edad</label>
                <asp:TextBox runat="server" CssClass="form-control" ID="tbedad"></asp:TextBox>
            </div>            
            <div class="mb-3">
                <label class="form-label">Fecha de nacimiento</label>
                <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="tbdate"></asp:TextBox>
            </div>
            <asp:Button runat="server" ID="BtnCreate" CssClass="btn btn-primary" Text="Crear" OnClick="BtnCreate_Click"/>           
            <asp:Button runat="server" ID="BtnVolver" CssClass="btn btn-primary btn-dark" Text="Volver" OnClick="BtnVolver_Click"/>
        </div>
    </form>
</asp:Content>
