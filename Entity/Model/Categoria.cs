﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Categoria
    {
        [Key]
        [Required]
        public int IdCategoria { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
