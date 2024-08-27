using System.ComponentModel.DataAnnotations;

namespace AppWebBootstrap.Models
{
    public class Logradouro : Base
    {
        [Required]
        public string Cep { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Pais { get; set; }
    }
}