using System;
using System.Collections.Generic;

#nullable disable

namespace EjemploIngenieriaInversa.Modelos
{
    public partial class Telefono
    {
        public int IdTelefono { get; set; }
        public int CodigoEst { get; set; }
        public int Numero { get; set; }

        public virtual Estudiante CodigoEstNavigation { get; set; }
    }
}
