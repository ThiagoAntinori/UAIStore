using Entity;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriaDao
    {
        private static AppDbContext getAppDbContext()
        {
            AppDbContextFactory appDbContextFactory = new AppDbContextFactory();
            AppDbContext appDbConext = appDbContextFactory.CreateDbContext(null);
            return appDbConext;
        }

        public List<CategoriaEntity> GetAll()
        {
            try
            {
                using(var appDbContext = getAppDbContext())
                {
                    return appDbContext.Categorias.Select(c => CategoriaMapper.Map(c)).ToList();
                }
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
                return this.GetAll().Where(c => c.IdCategoria == idCategoria).FirstOrDefault()!;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
