using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio1
{
    public class Persona
    {
        string nombre;
        string apellido;
        string direccion;
        DateTime fechadenacimiento;
        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        
        public int edad()
        {
            DateTime fechaactual = DateTime.Today;
            int edad = fechaactual.Year - fechadenacimiento.Year;

            if(fechadenacimiento.Month > fechaactual.Month)
            {
                edad--;
            }
            return edad;
        }
    }
}