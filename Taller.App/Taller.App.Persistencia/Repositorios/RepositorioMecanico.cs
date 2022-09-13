using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia
{
    public class RepositorioMecanico
    {

        private readonly ContextDb dbContext;


        public RepositorioMecanico(ContextDb dbContext)
        {

            this.dbContext = dbContext;
        }

        public Mecanico AgregarMecanico(Mecanico m)
        {

            var mecanicoNuevo = this.dbContext.Mecanics.Add(m);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;

        }


    }
}