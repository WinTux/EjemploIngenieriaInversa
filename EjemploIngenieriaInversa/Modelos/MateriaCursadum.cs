using System;
using System.Collections.Generic;

#nullable disable

namespace EjemploIngenieriaInversa.Modelos
{
    public partial class MateriaCursadum
    {
        public int IdMC { get; set; }
        public int IdEst { get; set; }
        public string IdMat { get; set; }
        public decimal? Calificacion { get; set; }

        public virtual Estudiante IdEstNavigation { get; set; }
        public virtual Materium IdMatNavigation { get; set; }
    }
}
