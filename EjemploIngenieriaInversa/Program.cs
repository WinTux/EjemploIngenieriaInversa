using System;

namespace EjemploIngenieriaInversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             Reverse Engineering
            =====================
            Agegamos los paquetes:
            EntityFrameworkCore.SqlServer
            EntityFrameworkCore.Tools

            Abrimos la Consola del Administrador de paquetes

            Ejecutamos:

            PM> scaffold-dbcontext -Provider EntityFrameworkCore.SqlServer
                -Connection "Server=192.168.1.253;Database=ddbb_que_exista;User=sa;Password=123456;"

            podemos usar -OutputDir para poner nombre de folder para modelos
            -ContextDir para poer nom,bre de folder para el contexto
            -Context para dar un nombre a nuestro contexto generado.

            Podemos usar -Tables y -Schema para listar las tablas y esquemas que nos interesen, separados por comas

             */
        }
    }
}
