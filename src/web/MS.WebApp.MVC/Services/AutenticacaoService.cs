using Microsoft.Extensions.Options;
using MS.WebApp.MVC.Extensions;
using MS.WebApp.MVC.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MS.WebApp.MVC.Services
{
	public class AutenticacaoService : Service, IAutenticacaoService
	{
		private readonly HttpClient _httpClient;
		public AutenticacaoService(HttpClient httpClient, IOptions<AppSettings> settings)
		{
			httpClient.BaseAddress = new Uri(settings.Value.AutenticacaoUrl);
			_httpClient = httpClient;
		}
		public async Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin)
		{
			var content = ObterConteundo(usuarioLogin);

			var response = await _httpClient.PostAsync("/api/Auth/autenticar", content);

			if (!TratarErrosResponse(response))
			{
				return new UsuarioRespostaLogin
				{
					ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
				};
			}

			return await DeserializarObjetoResponse<UsuarioRespostaLogin>(response);
		}

		public async Task<UsuarioRespostaLogin> Regitro(UsuarioRegistro usuarioRegistro)
		{
			var content = ObterConteundo(usuarioRegistro);
			var response = await _httpClient.PostAsync("/api/Auth/nova-conta", content);

			if (!TratarErrosResponse(response))
			{
				return new UsuarioRespostaLogin
				{
					ResponseResult = await DeserializarObjetoResponse<ResponseResult>(response)
				};
			}

			return await DeserializarObjetoResponse<UsuarioRespostaLogin>(response);
		}
	}
}
