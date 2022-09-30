using System;
using System.Collections.Generic;

#nullable disable

namespace EjemploIngenieriaInversa.Modelos
{
    public partial class Materium
    {
        public Materium()
        {
            MateriaCursada = new HashSet<MateriaCursadum>();
        }

        public string Sigla { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MateriaCursadum> MateriaCursada { get; set; }
    }
}
