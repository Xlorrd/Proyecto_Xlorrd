using Capa_Datos;
using Capa_Negocio;
using System;
using System.Collections.Generic;
namespace Capa_Vista
{
    public partial class Main_Template : System.Web.UI.MasterPage
    {
        private Tbl_Usuario info = new Tbl_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Timeout = 10;

                if (Session["New"] != null)
                {
                    Capturar_usuario();
                    Obtener_Datos_Persona();
                    Capturar_fecha();


                }
                else
                {
                    //Response.Redirect("~/Auntentificar_Usuario.aspx");
                }

            }
        }
        private void Capturar_fecha()
        {
         
                var fecha = DateTime.Now.Date;

            lbl_fecha.Text = ("Quito,  " + fecha.ToString("dd ") + "de " + fecha.ToString("MMMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ESP")) + " del " + fecha.ToString("yyyy") + " .");
            //lbl_fecha.Text = fecha.ToString("dd/MM/yyyy");
        }
        private void Capturar_usuario()
        {
            string nombre = Convert.ToString(Session["New"]);
            var rs = Logica_Tbl_Usuario.Buscar_Usuario_Nombre(nombre);
            List<sp_buscar_usuario_nombreResult> data = new List<sp_buscar_usuario_nombreResult>();

            foreach (var item in rs)
            {
                sp_buscar_usuario_nombreResult a = new sp_buscar_usuario_nombreResult();
                a.ID = item.ID;
                a.Alias = item.Alias;
                data.Add(a);


                //lbl_Usuario.Text  = Convert.ToString(a.Alias);
            }
            Session["Alias"] = data[0].Alias.ToString();
            Session["ID_Usuario"] = data[0].ID.ToString();

            lbl_Usuario.Text = Session["Alias"].ToString();

          
        }

        public void Obtener_Datos_Persona()
        {
            int usu_id = Convert.ToInt32(Session["ID_Usuario"]);
            try
            {
                var rs = Logica_Tbl_Persona.Buscar_Persona_Id(usu_id);
                List<sp_buscar_persona_idResult> data = new List<sp_buscar_persona_idResult>();

                foreach (var item in rs)
                {
                    sp_buscar_persona_idResult a = new sp_buscar_persona_idResult();
                    a.Nombre = item.Nombre;
                    a.Apellido = item.Apellido;

                    data.Add(a);


                    //lbl_Usuario.Text  = Convert.ToString(a.Alias);
                    string nombre = data[0].Nombre;
                    string apellido = data[0].Apellido;
                    string nom_completo = apellido + "  " + nombre;
                    lbl_persona.Text = nom_completo.ToUpper(new System.Globalization.CultureInfo("es", false));

                    lbl_persona.Font.Bold = true;
                }
            


            }
            catch (UnauthorizedAccessException)
            {

                return;
            }


        }
    }
}