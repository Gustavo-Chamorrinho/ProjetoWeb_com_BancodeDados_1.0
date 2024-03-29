﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace testandoBancodDo0.Models
{
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }
        [Required]
        public string Name { get; set; } = null;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null;
        [Required]
        public string Senha { get; set; } = null;
    }
}
