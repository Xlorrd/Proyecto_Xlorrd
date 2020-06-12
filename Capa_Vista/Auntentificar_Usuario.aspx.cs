using Capa_Datos;
using Capa_Negocio;
using System;

namespace Capa_Vista
{
    public partial class Auntentificar_Usuario : System.Web.UI.Page
    {
        int contador = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["con"] = Session["ConAntiguo"];
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            Validar_Usuario();

            //Verificar_Usuario();


        }

        public void Verificar_Usuario()
        {
            string per_nombre = txt_usuario.Text;
          var rs=  Logica_Tbl_Usuario.Verificar_Usuario(per_nombre," ");
            
            
            intento.Text = rs;
            //if (rs)
            //{

            //}

          


        }
        public void bloquear_persona()
        {
            string per_nombre = txt_usuario.Text;
            Logica_Tbl_Usuario.bloquear_usuario(per_nombre);
            intento.Text = "La cuenta ha sido desactivada";
        }
        public void Validar_Usuario()
        {

            if (string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contra.Text))
            
            {
                intento.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                Session["ConAntiguo"] = intento.Text.ToString();
                if (Convert.ToInt32(intento.Text) == 3)
                {
                    bloquear_persona();
                    btn_ingresar.Enabled = false;
                    Session["con"] = null;
                    Session["ConAntiguo"] = null;
                }
            }

            //  lblMensaje.Visible = false;
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {               
                // lblMensaje.Visible = true;

                txt_usuario.Attributes.Add("placeholder", "Escribe un usuario");
                // txt_usu.BorderColor=System.Drawing.Color.FromArgb(255,0,0) ;
                // txt_usu.BorderStyle = BorderStyle.Solid;      
                return;
            }

            if (string.IsNullOrEmpty(txt_contra.Text))
            {               
                //  lblMensaje.Visible = true;
                txt_contra.Attributes.Add("placeholder", "Ingrese  una clave");
                return;
            }

            bool existe = Logica_Tbl_Usuario.Autentificar(txt_usuario.Text, txt_contra.Text);
            {
                if (existe)
                {
                    Tbl_Usuario usuario = new Tbl_Usuario();
                    usuario = Logica_Tbl_Usuario.Autentificar_Usuario(txt_usuario.Text, txt_contra.Text);

                    int tipousuario = Convert.ToInt32(usuario.roll_id);

                    if (tipousuario == 1)
                    {
                        Session["New"] = txt_usuario.Text;
                        Response.Redirect("~/Pruebas_Menu.aspx");

                    }
                    if (tipousuario == 2)
                    {

                        Session["New"] = txt_usuario.Text;
                        Response.Redirect("~/Cli_menu.aspx");

                    }
                    if (tipousuario == 3)
                    {
                        Session["New"] = txt_usuario.Text;
                        Response.Redirect("~/Doc_menu.aspx");

                    }
                    if (tipousuario == 5)
                    {
                        Session["New"] = txt_usuario.Text;
                        Response.Redirect("~/xprueba.aspx");

                    }



                }
                else
                {
                    //  lblMensaje.Visible = true;
                    txt_contra.Attributes.Add("placeholder", "Contraseña o usuario incorrecto");
                    intento.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                    Session["ConAntiguo"] = intento.Text.ToString();
                    if (Convert.ToInt32(intento.Text) == 3)
                    {
                        bloquear_persona();
                        btn_ingresar.Enabled = false;
                        Session["con"] = null;
                        Session["ConAntiguo"] = null;
                    }
                    return;
                   
                }

            }

        }
    }
}