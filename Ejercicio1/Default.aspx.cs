using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio1
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnos = new List<Alumno>();
        static List<Nota> notas = new List<Nota>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                alumnos = new List<Alumno>();
        }

        protected void btmIngresar_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = DropDownList1.SelectedValue;
            nota.Calificacion = Convert.ToInt32(txtNota.Text);
            txtNota.Text = ""; 
            notas.Add(nota);
        }
        
        protected void Guardar()
        {
            string json = JsonConvert.SerializeObject(alumnos);
            string archivo = Server.MapPath("NOTAS.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void btmGuardar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Direccion = txtDireccion.Text;
            
            alumno.Notas = notas.ToList();

            alumnos.Add(alumno);
            Guardar();

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNota.Text = "";

            notas.Clear();

        }
    }
}