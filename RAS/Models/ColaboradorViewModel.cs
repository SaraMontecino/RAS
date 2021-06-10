using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RAS.Models
{
    public class ColaboradorViewModel 
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Campo Login obrigatório")]
        [MaxLength(50)]
        public string Login { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Senha obrigatório")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        public string Senha { get; set; }
    }
}
