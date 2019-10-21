﻿using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocio
{
    public class Logica_Tbl_Usuario
    {
        public static ProyectoXDataContext dc = new ProyectoXDataContext();

        public static Tbl_Usuario Autentificar_Usuario(String nombre, string pass)
        {
            var nlogin = dc.Tbl_Usuario.Single(usu => usu.usu_estado == "A" & usu.usu_nombre.Equals(nombre)
            & usu.usu_contra.Equals(pass));
            return nlogin;
        }

        public static bool Autentificar(string nombre, String pass)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == "A" & usu.usu_nombre.Equals(nombre)
            & usu.usu_contra.Equals(pass));
            return auto;
        }

        public static List<sp_buscar_usuario_nombreResult> Buscar_Usuario_Nombre(string usu_nombre)
        {
            var dta = dc.sp_buscar_usuario_nombre(usu_nombre);

              
            return dta.ToList();
        }


    }
}