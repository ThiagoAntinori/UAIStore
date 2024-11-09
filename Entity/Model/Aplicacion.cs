using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Aplicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdAplicacion { get; set; }
        [Required]
        [MinLength(5)]
        public string Titulo { get; set; }
        [Required]
        [MinLength(15)]
        public string Descripcion { get; set; }
        [Required]
        public string Desarrolladora { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        [Required]
        public Categoria Categoria { get; set; }
    }
}
