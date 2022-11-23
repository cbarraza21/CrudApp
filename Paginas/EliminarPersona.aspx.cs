using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApp.Paginas
{
    public partial class EliminarPersona : System.Web.UI.Page
    {
        ModeloNegocio.DetallePersona detalleEliminar = new ModeloNegocio.DetallePersona();
        ModeloNegocio.EliminarPersona eliminarP = new ModeloNegocio.EliminarPersona();
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona;

            if (!Page.IsPostBack)
            {
                long sID = (long)Id_PersonaEnQueryString;
                persona = detalleEliminar.Obtener(sID);

                if (persona != null)
                {
                    tbnombre.Text = persona.Nombre;
                    tbapellido.Text = persona.Apellido;
                    tbedad.Text = persona.Edad.ToString();
                    tbdate.Text = persona.Fecha_Nacimiento.ToString("dd/MM/yyyy");
                }
            }

        }

        private long? Id_PersonaEnQueryString
        {
            get
            {
                long? Id_Persona = default(long?);
                if (Request.QueryString["Id_Persona"] != null)
                {
                    try
                    {
                        Id_Persona = Convert.ToInt64(Request.QueryString["Id_Persona"]);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                return Id_Persona;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {            
            long sID = (long)Id_PersonaEnQueryString;

            eliminarP.Eliminar(sID);
            Response.Redirect("Inicio.aspx");

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}