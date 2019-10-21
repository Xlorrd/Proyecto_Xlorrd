using System;

namespace Capa_Vista
{
    public partial class Pruebas_Main_Template : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Prueba();
            }

        }

        private void Prueba()
        {
            AcmeSer.AcmeSer ws = new AcmeSer.AcmeSer();
            var ds = ws.ObtenerEmpleado();
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
        }
    }
}