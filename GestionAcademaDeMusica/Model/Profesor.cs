using System;

namespace GestionAcademaDeMusica
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Especialidad { get; set; }
        public decimal TarifaHora { get; set; }
        public decimal TarifaConIVA => Math.Round(TarifaHora * 1.19m, 2);
        public bool Activo { get; set; }

        public Profesor()
        {
            Activo = true;
        }
    }
}
