using Capa_Datos;
using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Capa_Vista
{
    public partial class Actualizar_Persona : System.Web.UI.Page
    {
        private Tbl_Persona info = new Tbl_Persona();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Obtener_Datos_Persona();
                Obtener_Datos_Persona_Usuario();
            }
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
                    a.Dirección = item.Dirección;
                    a.Cédula = item.Cédula;
                    a.Mail = item.Mail;
                    a.Fch_Nacimiento = item.Fch_Nacimiento;
                    data.Add(a);


                    //lbl_Usuario.Text  = Convert.ToString(a.Alias);
                    txt_nombre.Text = data[0].Nombre;
                    txt_apellido.Text = data[0].Apellido;
                    txt_direccion.Text = data[0].Dirección;
                    txt_cedula.Text  = Convert.ToString(data[0].Cédula);
                    txt_correo.Text = data[0].Mail;
                    txt_fch_nacimiento.Text = data[0].Fch_Nacimiento;
                }


            }
            catch (UnauthorizedAccessException)
            {

                return;
            }


        }

        private void Obtener_Datos_Persona_Usuario()
        {
            int usu_id = Convert.ToInt32(Session["ID_Usuario"]);
            var rs = Logica_Tbl_Persona.Busca_Usuario_Persona_ID(usu_id);
            foreach (var item in rs)
            {
                Session["per_id"] = rs[0].usu_id;            
                txt_nombre.Text = rs[0].Nombre;
                txt_apellido.Text = rs[0].Apellido;
                txt_direccion.Text = rs[0].Dirección;
                txt_cedula.Text = Convert.ToString(rs[0].Cédula);
                txt_correo.Text = rs[0].Mail;
                txt_fch_nacimiento.Text = rs[0].Fch_Nacimiento;
            }

        }

        private void Actualizar_Datos_Persona_Usuario()
        {
            //try
            //{

           
           Tbl_Persona data = new Tbl_Persona();
            Tbl_Persona id = new Tbl_Persona();
            int per_id = Convert.ToInt32(Session["per_id"]);
        
            data.per_nombre = txt_nombre.Text;
            data.per_apellido = txt_apellido.Text;
            data.per_cedula =Convert.ToInt32(txt_cedula.Text);
            data.per_correo = txt_correo.Text;
            data.per_fch_nacimiento =Convert.ToDateTime("2019-10-30");
            data.per_direccion = txt_direccion.Text;

            Logica_Tbl_Persona.Actualizar_Persona(data,per_id);
                  Response.Redirect("~/Actualizar_Persona.aspx");
            }
        //    catch (Exception)
        //    {
        //        btn_guardar.Attributes.Add("onclick", "demo.showNotification('top','center');");
        //    }
          
       
        //}
        protected void btn_guardar_Click(object sender, EventArgs e)
        {



            Actualizar_Datos_Persona_Usuario();
            //btn_guardar.Attributes.Add("onclick", "demo.showNotification('top','center');");

        }
    }
}