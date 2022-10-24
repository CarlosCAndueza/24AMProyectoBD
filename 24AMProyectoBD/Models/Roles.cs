using System;
using System.ComponentModel.DataAnnotations;

namespace _24AMProyectoBD.Models
{
    public class Roles
    {
        [Key]
        public int PkRol { get; set; }
        public string Nombre { get; set; }
    }
}
