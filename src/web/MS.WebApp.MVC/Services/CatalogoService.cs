﻿using Microsoft.Extensions.Options;
using MS.WebApp.MVC.Extensions;
using MS.WebApp.MVC.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MS.WebApp.MVC.Services
{
	public class CatalogoService : Service, ICatalogoService
	{
		private readonly HttpClient _httpClient;

		public CatalogoService(HttpClient httpClient,
			 IOptions<AppSettings> settings)
		{
			httpClient.BaseAddress = new Uri(settings.Value.CatalogoUrl);

			_httpClient = httpClient;
		}
		public async Task<ProdutoViewModel> ObterPorId(Guid id)
		{
			var response = await _httpClient.GetAsync($"/catalogo/produtos/{id}");

			TratarErrosResponse(response);

			return await DeserializarObjetoResponse<ProdutoViewModel>(response);
		}

		public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
		{
			var response = await _httpClient.GetAsync("/catalogo/produtos/");

			TratarErrosResponse(response);

			return await DeserializarObjetoResponse<IEnumerable<ProdutoViewModel>>(response);
		}
	}
}
