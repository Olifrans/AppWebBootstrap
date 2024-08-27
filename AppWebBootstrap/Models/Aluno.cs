using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebBootstrap.Models
{
    public class Aluno : Base
    {
        [Required]
        public string Nome { get; set; }
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        public bool Status { get; set; }

        [Required]
        public Logradouro Logradouro { get; set; }
    }
}
