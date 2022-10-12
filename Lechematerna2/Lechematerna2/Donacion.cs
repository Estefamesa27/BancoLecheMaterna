using System;

namespace Entidades
{
    class Donacion
    {
        public DateTime FechaRecp { get; set; }
        public int IdRecip { get; set; }
        public int CantLeche { get; set; }
        public DateTime FechaVenc { get; set; }
    }
}
