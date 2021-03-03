namespace MS.Identidade.API.Extensions
{
	public class AppSettings
	{
		/// <summary>
		/// Chave do token
		/// </summary>
		public string Secret { get; set; }
		/// <summary>
		/// Tempo de validação do token
		/// </summary>
		public int ExpiracaoHoras { get; set; }
		public string Emissor { get; set; }
		public string ValidoEm { get; set; }
	}
}
