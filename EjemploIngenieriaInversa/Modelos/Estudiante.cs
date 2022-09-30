using System;
using System.Collections.Generic;

#nullable disable

namespace EjemploIngenieriaInversa.Modelos
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            MateriaCursada = new HashSet<MateriaCursadum>();
            Telefonos = new HashSet<Telefono>();
        }

        public int Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public virtual ICollection<MateriaCursadum> MateriaCursada { get; set; }
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}
