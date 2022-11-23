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
    public partial class CrearPersona : System.Web.UI.Page
    {
        ModeloNegocio.CrearPersona persona1 = new ModeloNegocio.CrearPersona();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona()
            {
                Nombre = tbnombre.Text,
                Apellido = tbapellido.Text,
                Edad = int.Parse(tbedad.Text),
                Fecha_Nacimiento = DateTime.Parse(tbdate.Text)

            };
            persona1.Crear(persona);
            Response.Redirect("Inicio.aspx");

        }


        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}