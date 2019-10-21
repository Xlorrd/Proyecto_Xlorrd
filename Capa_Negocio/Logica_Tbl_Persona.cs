using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capa_Negocio
{

    public class Logica_Tbl_Persona
    {

        public static ProyectoXDataContext dc = new ProyectoXDataContext();

        public static List<sp_buscar_persona_idResult> Buscar_Persona_Id(int per_id)
        {
            var per = dc.sp_buscar_persona_id(per_id);
            return per.ToList();
        }

        public static List<sp_buscar_usuario_personaResult> Busca_Usuario_Persona_ID(int per_id)
        {
            var per = dc.sp_buscar_usuario_persona(per_id);         
            List<sp_buscar_usuario_personaResult> data = new List<sp_buscar_usuario_personaResult>();

            foreach (var item in per)
            {
                sp_buscar_usuario_personaResult a = new sp_buscar_usuario_personaResult();
                a.usu_id = item.per_id;
                a.per_id = item.per_id;
                a.Nombre = item.Nombre;
                a.Apellido = item.Apellido;
                a.Dirección = item.Dirección;
                a.Cédula = item.Cédula;
                a.Mail = item.Mail;
                a.Fch_Nacimiento = item.Fch_Nacimiento;
                data.Add(a);


                data.Add(a);
            }

            return data;
        }

        public static void Guardar_Persona(Tbl_Persona tp)
        {

            try
            {
                dc.sp_insertar_persona(tp.per_nombre, tp.per_apellido, tp.per_cedula, tp.per_correo, tp.per_fch_nacimiento, tp.per_direccion, tp.per_fch_creacion, tp.per_estado);

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("los datos no han sido guardados <br/>" + ex.Message);
            }

        }

        public static void Actualizar_Persona(Tbl_Persona tp, int per_id )
        {
            try
            {
                dc.sp_actualizar_persona(per_id, tp.per_nombre, tp.per_apellido, tp.per_cedula, tp.per_correo,tp.per_fch_nacimiento, tp.per_direccion,tp.per_fch_creacion, tp.per_estado);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

