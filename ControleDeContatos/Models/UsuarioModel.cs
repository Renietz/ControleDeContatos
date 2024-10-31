using System.ComponentModel.DataAnnotations;
using ControleDeContatos.Enums;
using Microsoft.AspNetCore.Components.Web;

namespace ControleDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do contato")]

        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é válido")]

        public string Email { get; set; }
      

        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "Digite a senha do usuário")]

        public string Senha { get; set; }
        [Required(ErrorMessage = "Digite o nome do contato")]


        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }


        public  bool SenhaValida(string senha)
        {
            return Senha == senha;
        }

    }
}
