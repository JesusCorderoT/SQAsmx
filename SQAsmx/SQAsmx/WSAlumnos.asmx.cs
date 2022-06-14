using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Negocio;
using Entidades;



namespace SQAsmx
{
    /// <summary>
    /// Descripción breve de WSAlumnos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WSAlumnos : System.Web.Services.WebService
    {

      


        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public AportacionesIMSS CalcularIMSS(int id)
        {
           
                NAlumno na = new NAlumno();
                Alumno alumno = na.Consultar(id);
                decimal? Sueldo = alumno.sueldo;
                AportacionesIMSS aportacionesIMSS = na.CalcularIMSS((decimal)Sueldo);
                return aportacionesIMSS;
          
            
        }

        [WebMethod]
        public ItemTablaISR CalcularISR(int id)
        {
            NAlumno NAlumno = new NAlumno();
            Alumno alumno = NAlumno.Consultar(id);
            decimal? Sueldo = (alumno.sueldo) /2 ;
            ItemTablaISR itemTablaISR = NAlumno.CalcularISR((decimal)Sueldo);
            return itemTablaISR;
        }
    }
}
