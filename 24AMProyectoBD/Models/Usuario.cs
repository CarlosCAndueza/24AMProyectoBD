﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24AMProyectoBD.Models
{
    public class Usuario
    {
        [Key]
        public int PkUsuario { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        
        [ForeignKey("Roles")]
        public int? FkRol { get; set; }

    }
}
