using System.ComponentModel.DataAnnotations;

namespace LanchesThi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        //será usado para levar o usuário de volta para a página que ele estava tentando acessar antes
        public string ReturnUrl { get; set; }

    }
}
