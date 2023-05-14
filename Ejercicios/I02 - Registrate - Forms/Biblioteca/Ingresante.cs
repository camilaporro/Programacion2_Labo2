using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string cursosString = string.Empty;

            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Edad: {this.edad}");
            stringBuilder.AppendLine($"Direccion: {this.direccion}");
            stringBuilder.AppendLine($"Genero: {this.genero}");
            stringBuilder.AppendLine($"Pais: {this.pais}");

            foreach (string curso in this.cursos)
            {
                cursosString += $"\n{curso} ";
            }
            stringBuilder.AppendLine($"Curso/s: {cursosString}");

            return stringBuilder.ToString();
        }
    }
}