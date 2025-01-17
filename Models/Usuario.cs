﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PIM_4_Semestre.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
