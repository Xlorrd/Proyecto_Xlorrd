using System;
using Capa_Datos;
using Capa_Negocio;
using System.IO.Ports;

using System.Collections.Generic;

namespace Capa_Vista
{
    public partial class Pruebas_Menu : System.Web.UI.Page
    {
        private SerialPort puerto = new SerialPort();
        protected void Page_Load(object sender, EventArgs e)
        {
            //mostra_grid();
            arduino();


        }

        public void arduino()
        {

            try
            {
                this.puerto.PortName = "COM3";
                this.puerto.BaudRate = 9600;
                if (!puerto.IsOpen)
                {

                    //puerto.Open();
                    Label1.Text = "arduino conectado";


                }



                {

                }


            }
            catch (Exception)
            {
                Label1.Text = "Conecta el arduino";

            }



        }

        public void scanearpuertos()
        {
            var mypuerto = SerialPort.GetPortNames();

            TextBox1.Text = Convert.ToString(mypuerto);
        }

        public void mostra_grid()
        {
            List<Migrar_datos_personaResult> objeto = new List<Migrar_datos_personaResult>();


            var lista = MigracionDatos.DatosPersona();

            foreach (var item in lista)
            {
                Migrar_datos_personaResult a = new Migrar_datos_personaResult();
                Tbl_Persona info = new Tbl_Persona();

                a.Nombres = item.per_nombres;
                a.Apellidos = item.per_apellidos;
                a.Cédula = item.per_cedula;
                a.Mail = item.per_email;
                a.Dirección = item.per_direccion;

                objeto.Add(a);
                info.per_nombre = a.Nombres;
                info.per_apellido = a.Apellidos;
                info.per_cedula = a.Cédula;
                info.per_correo = a.Mail;
                info.per_direccion = a.Dirección;
                Logica_Tbl_Persona.Guardar_Persona(info,Label1.Text);

            }

            GridView1.DataSource = objeto;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mostra_grid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                puerto.Open();
                string entrada = puerto.ReadLine();
                puerto.Close();
                TextBox1.Text = entrada;
            }
            catch (Exception)
            {

                throw;
            }
          

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!puerto.IsOpen)
                {
                    puerto.Open();
                    string entrada = puerto.ReadLine();
                    puerto.Close();
                    TextBox1.Text = entrada;
                }

            }
            catch (Exception )
            {

                Timer1.Enabled = false;

            }

        }
    }
}
