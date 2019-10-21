using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
   public class MigracionDatos
    {
     public static   Proyecto_CitasDataContext dc = new Proyecto_CitasDataContext();
        public static List<Mostrar_PersonaResult> DatosPersona()
        {
            var dtos = dc.Mostrar_Persona();
                return dtos.ToList();
        }
        
    }
}
