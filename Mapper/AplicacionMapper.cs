using Entity;
using Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public static class AplicacionMapper
    {
        public static AplicacionEntity Map (Aplicacion aplicacion)
        {
            try
            {
                return new AplicacionEntity
                {
                    IdAplicacion = aplicacion.IdAplicacion,
                    Titulo = aplicacion.Titulo,
                    Descripcion = aplicacion.Descripcion,
                    Desarrolladora = aplicacion.Desarrolladora,
                    Precio = aplicacion.Precio,
                    Categoria = CategoriaMapper.Map(aplicacion.Categoria)
                };
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public static Aplicacion Map(AplicacionEntity aplicacion)
        {
            try
            {
                return new Aplicacion
                {
                    IdAplicacion = aplicacion.IdAplicacion,
                    Titulo = aplicacion.Titulo,
                    Descripcion = aplicacion.Descripcion,
                    Desarrolladora = aplicacion.Desarrolladora,
                    Precio = aplicacion.Precio,
                    Categoria = CategoriaMapper.Map(aplicacion.Categoria)
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
