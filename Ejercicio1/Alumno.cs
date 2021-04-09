using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio1
{
    public class Nota
    {
        int calificacion;
        string curso;

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string Curso { get => curso; set => curso = value; }
    }
    public class Alumno : Persona
    {
        string carne;
        List<Nota> notas = new List<Nota>();

        public string Carne { get => carne; set => carne = value; }
        public List<Nota> Notas { get => notas; set => notas = value; }

        public Alumno()
        {
            Notas = new List<Nota>();
        }
    }
}