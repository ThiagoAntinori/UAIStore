using DAL;
using Entity.Model;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace BLL
{
    public class AplicacionBusiness
    {
        private AplicacionDao AplicacionDao = new AplicacionDao();
        private CategoriaBusiness CategoriaBusiness = new CategoriaBusiness();

        public void crearAplicacion(AplicacionEntity aplicacion)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    if(aplicacion.Precio < 0)
                    {
                        throw new Exception("El precio no puede ser menor que cero.");
                    }
                    if(aplicacion.Titulo.Length < 5)
                    {
                        throw new Exception("El titulo debe tener al menos 5 caracteres.");
                    }
                    if(aplicacion.Descripcion.Length < 15)
                    {
                        throw new Exception("La descripción debe tener al menos 15 caracteres.");
                    }
                    if(aplicacion.Categoria == null)
                    {
                        throw new Exception("La aplicacion debe tener una categoria asignada.");
                    }
                    if(CategoriaBusiness.GetAll().Where(c => c.IdCategoria == aplicacion.Categoria.IdCategoria).ToList().Count <= 0)
                    {
                        throw new Exception("No se encontró la categoria seleccionada");
                    }
                    AplicacionDao.crearAplicacion(aplicacion);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void crearMultiplesAplicaciones(List<AplicacionEntity> aplicaciones)
        {
            try
            {
                using(var trx = new TransactionScope())
                {
                    foreach(AplicacionEntity app in aplicaciones)
                    {
                        this.crearAplicacion(app);
                    }
                    trx.Complete();
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
                if(AplicacionDao.GetAll().Where(a => a.IdAplicacion == aplicacionModificada.IdAplicacion).ToList().Count <= 0)
                {
                    throw new Exception($"No se encontró una aplicación con ese ID ({aplicacionModificada.IdAplicacion})");
                }
                if (aplicacionModificada.Precio < 0)
                {
                    throw new Exception("El precio no puede ser menor que cero.");
                }
                if (aplicacionModificada.Titulo.Length < 5)
                {
                    throw new Exception("El titulo debe tener al menos 5 caracteres.");
                }
                if (aplicacionModificada.Descripcion.Length < 15)
                {
                    throw new Exception("La descripción debe tener al menos 15 caracteres.");
                }
                AplicacionDao.modificarAplicacion(aplicacionModificada);
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
                if (AplicacionDao.GetAll().Where(a => a.IdAplicacion == idAplicacion).ToList().Count <= 0)
                {
                    throw new Exception($"No se encontró una aplicación con ese ID ({idAplicacion})");
                }
                AplicacionDao.eliminarAplicacion(idAplicacion);
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
                return AplicacionDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
