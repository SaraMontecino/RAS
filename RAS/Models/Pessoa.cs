using System;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class Pessoa
    {
        public int? Pessoas_id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo nome obrigatório")]
        [MinLength(3)]
        public string Nome { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Campo cpf obrigatório")]
        [MaxLength(14)]  
        public string Cpf { get; set; }

        [Display(Name = "Data de Nascimento ")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Email")]
        [MinLength(15)]
        public string Email { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Campo sexo obrigatório")]
        [MinLength(1)]
        public string Sexo { get; set; }

        [Display(Name = "Telefone")]
        [MaxLength(15)] 
        public string Telefone { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Campo status obrigatório")]
        public int Status { get; set; }
    }
}
