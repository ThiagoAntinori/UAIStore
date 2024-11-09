using Entity;
using Entity.Model;
using Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AplicacionDao
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public void crearAplicacion(AplicacionEntity aplicacion)
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    Aplicacion nuevaAplicacion = AplicacionMapper.Map(aplicacion);
                    appDbContext.Entry(nuevaAplicacion.Categoria).State = EntityState.Unchanged;
                    appDbContext.Aplicaciones.Add(nuevaAplicacion);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void modificarAplicacion(AplicacionEntity aplicacionModificada)
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    Aplicacion aplicacionToUpdate = appDbContext.Aplicaciones.Where(a => a.IdAplicacion == aplicacionModificada.IdAplicacion).FirstOrDefault()!;
                    aplicacionToUpdate.Titulo = aplicacionModificada.Titulo;
                    aplicacionToUpdate.Descripcion = aplicacionModificada.Descripcion;
                    aplicacionToUpdate.Desarrolladora = aplicacionModificada.Desarrolladora;
                    aplicacionToUpdate.Precio = aplicacionModificada.Precio;
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminarAplicacion(int idAplicacion)
        {
            try
            {
                using(var appDbContext = getAppDbContext())
                {
                    Aplicacion aplicacionToRemove = appDbContext.Aplicaciones.Where(a => a.IdAplicacion == idAplicacion).FirstOrDefault()!;
                    appDbContext.Aplicaciones.Remove(aplicacionToRemove);
                    appDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<AplicacionEntity> GetAll()
        {
            try
            {
                using (var appDbContext = getAppDbContext())
                {
                    return appDbContext.Aplicaciones.Include(a => a.Categoria).Select(a => AplicacionMapper.Map(a)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
