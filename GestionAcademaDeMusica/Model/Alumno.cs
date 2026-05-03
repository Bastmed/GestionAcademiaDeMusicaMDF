using System;

namespace GestionAcademaDeMusica
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
        public int IdInstrumento { get; set; }
        public string NombreInstrumento { get; set; }

        public Alumno()
        {
            Activo = true;
            NombreInstrumento = "";
        }
    }
}
