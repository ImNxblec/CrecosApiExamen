﻿using System.ComponentModel.DataAnnotations;

namespace CrecosApiExamen.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public bool Estado { get; set; }
    }
}
