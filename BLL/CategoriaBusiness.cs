using DAL;
using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBusiness
    {
        private CategoriaDao CategoriaDao = new CategoriaDao();

        public List<CategoriaEntity> GetAll()
        {
            try
            {
                return CategoriaDao.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public CategoriaEntity GetById(int idCategoria)
        {
            try
            {
                return CategoriaDao.GetById(idCategoria);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
