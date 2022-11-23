using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloNegocio;

namespace CrudApp.Paginas
{
    public partial class Inicio : System.Web.UI.Page
    {
        ListarPersonas persona1 = new ListarPersonas();
        protected void Page_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            gvp.DataSource = persona1.Listar();
            gvp.DataBind();
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Paginas/CrearPersona.aspx");
        }

        protected void BtnRead_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/DetallePersona.aspx?Id_Persona="+id);
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/EditarPersona.aspx?Id_Persona="+id);
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string id;
            Button BtnConsultar = (Button)sender;
            GridViewRow selectedrow = (GridViewRow)BtnConsultar.NamingContainer;
            id = selectedrow.Cells[1].Text;
            Response.Redirect("~/Paginas/EliminarPersona.aspx?Id_Persona="+id);
        }

    }
}