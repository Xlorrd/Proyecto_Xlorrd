﻿using System;
using Capa_Datos;
using Capa_Negocio;

using System.Collections.Generic;

namespace Capa_Vista
{
    public partial class Pruebas_Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //mostra_grid();
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
                a.Cédula=item.per_cedula;
                a.Mail = item.per_email;
                a.Dirección=item.per_direccion;              

                objeto.Add(a);
                info.per_nombre = a.Nombres;
                info.per_apellido = a.Apellidos;
                info.per_cedula = a.Cédula;
                info.per_correo = a.Mail;
                info.per_direccion = a.Dirección;
                Logica_Tbl_Persona.Guardar_Persona(info);

            }

            GridView1.DataSource = objeto;
            GridView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            mostra_grid();
        }
    }
}