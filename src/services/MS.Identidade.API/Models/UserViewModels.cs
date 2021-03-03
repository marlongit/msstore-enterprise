using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MS.Identidade.API.Models
{
	public class UsuarioRegistro
	{
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
		public string Email { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} está entre {2} e {1}", MinimumLength = 6)]
		public string Senha { get; set; }
		[Compare("Senha", ErrorMessage = "As senhas não conferem")]
		[Display(Name ="Confirmação de Senha")]
		public string SenhaConfirmacao { get; set; }
	}

	public class UsuarioLogin
	{
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
		public string Email { get; set; }
		[Required(ErrorMessage = "O campo {0} é obrigatório")]
		[StringLength(100, ErrorMessage = "O campo {0} está entre {2} e {1}", MinimumLength = 6)]
		public string Senha { get; set; }
	}

	public class UsuarioRespostaLogin
	{
		/// <summary>
		/// Token de acesso
		/// </summary>
		public string AcessoToken { get; set; }
		/// <summary>
		/// Tempo de expiração do token
		/// </summary>
		public double ExpiresIn { get; set; }
		/// <summary>
		/// Usuário que está logado com o token
		/// </summary>
		public UsuarioToken UsuarioToken { get; set; }
	}

	public class UsuarioToken
	{
		/// <summary>
		/// Código de identificação do usuário
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Email de login do usuário
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Lista de Claims ou permissões do usuário
		/// </summary>
		public IEnumerable<UsuarioClaim> Claims { get; set; }
	}

	public class UsuarioClaim
	{
		public string Value { get; set; }
		public string Type { get; set; }
	}
}
