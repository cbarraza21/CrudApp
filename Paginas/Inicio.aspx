<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="CrudApp.Paginas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Inicio
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
        <form runat="server">
        <br />
        <div class="mx-auto" style="width:300px">
            <h2>Listado</h2>
        </div>
        <br />
        <div class="container">
            <div class="row">
                <div class="col align-self-end">
                    <asp:Button runat="server" ID="BtnCreate" CssClass="btn btn-success form-control-sm" Text="Crear" OnClick="BtnCreate_Click"/>
                </div>
            </div>
        </div>
        <br />
        <div class="container row">
            <div class="table small">
                <asp:GridView runat="server" ID="gvp" class="table table-borderless table-hover">
                    <Columns>
                        <asp:TemplateField HeaderText="Opciones">
                            <ItemTemplate>                    
                                <asp:Button runat="server" ID="BtnRead" CssClass="btn form-control-sm btn-primary"  Text="Ver" Onclick="BtnRead_Click"/>
                                <asp:Button runat="server" ID="BtnUpdate" CssClass="btn form-control-sm btn-primary"  Text="Modificar" OnClick="BtnUpdate_Click"/>
                                <asp:Button runat="server" ID="BtnDelete" CssClass="btn form-control-sm btn-primary" Text="Eliminar" OnClick="BtnDelete_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</asp:Content>
