
using System;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;
namespace Taller.App.Consola
{

    class Program
    {

        private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );

        static void Main(string[] args)
        {
            Console.WriteLine("");
            AgregarMecanico();
        }

        static void AgregarMecanico()
        {
            var mecanico = new Mecanico
            {
                id = "23",
                nombre = "Orlando",
                fechaNacimiento = "10",
                nivelEstudio = "bachiller",
                telefono = "123",
                contrasenia = "123",
                rol = "jefeoperaciones"
            };
            repoMecanico.AgregarMecanico(mecanico);
        }

    }
}