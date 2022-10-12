using System;

namespace Entidades
{
    public class Madre
    {
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNaci { get; set; }
        public float Peso { get; set; }
        public float Talla { get; set; }
        public float imc { get; set; }
        public double UsoMedi { get; set; }
        public double HabTox { get; set; }
        public DateTime FechaUltR { get; set; }
        public DateTime FechaParto { get; set; }
        public int EdadAmeno { get; set; }
        public string PatolEmba { get; set; }
    }
}
