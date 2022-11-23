using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudApp.Paginas
{
    public partial class EditarPersona : System.Web.UI.Page
    {
        ModeloNegocio.DetallePersona detalleEditar = new ModeloNegocio.DetallePersona();
        ModeloNegocio.EditarPersona personaEdit = new ModeloNegocio.EditarPersona();
        protected void Page_Load(object sender, EventArgs e)
        {
            Persona persona;

            if (!Page.IsPostBack)
            {
                long sID = (long)Id_PersonaEnQueryString;
                persona = detalleEditar.Obtener(sID);

                if (persona != null)
                {
                    tbnombre.Text = persona.Nombre;
                    tbapellido.Text = persona.Apellido;
                    tbedad.Text = persona.Edad.ToString();                    
                    tbdate.Text = persona.Fecha_Nacimiento.ToString("dd/MM/yyyy");
                    //tbdate.TextMode = TextBoxMode.DateTime;
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

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            long sID = (long)Id_PersonaEnQueryString;
            Persona persona = new Persona();            

            if(persona != null)
            {
                persona.Id_Persona = (int)sID;
                persona.Nombre = tbnombre.Text;
                persona.Apellido = tbapellido.Text;
                persona.Edad = int.Parse(tbedad.Text);
                persona.Fecha_Nacimiento = DateTime.Parse(tbdate.Text);

            };
            personaEdit.Editar(persona);
            Response.Redirect("Inicio.aspx");

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}