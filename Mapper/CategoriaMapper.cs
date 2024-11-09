using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class CategoriaMapper
    {
        public static CategoriaEntity Map (Categoria categoria) 
        {
            return new CategoriaEntity
            {
                IdCategoria = categoria.IdCategoria,
                Descripcion = categoria.Descripcion
            };
        }

        public static Categoria Map(CategoriaEntity categoria)
        {
            return new Categoria
            {
                IdCategoria = categoria.IdCategoria,
                Descripcion = categoria.Descripcion
            };
        }
    }
}
