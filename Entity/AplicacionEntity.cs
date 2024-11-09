using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AplicacionEntity
    {
        private int idAplicacion;
        private string titulo;
        private string descripcion;
        private string desarrolladora;
        private double precio;
        private CategoriaEntity categoria;

        public int IdAplicacion { get => idAplicacion; set => idAplicacion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Desarrolladora { get => desarrolladora; set => desarrolladora = value; }
        public double Precio { get => precio; set => precio = value; }
        public CategoriaEntity Categoria { get => categoria; set => categoria = value; }
        public string DescripcionCategoria { get => categoria.Descripcion; }
    }
}
