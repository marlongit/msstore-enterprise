using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MS.WebApp.MVC.Models;
using MS.WebApp.MVC.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MS.WebApp.MVC.Controllers
{
	public class IdentidadeController : MainController
	{
		private readonly IAutenticacaoService _autenticacaoService;
		public IdentidadeController(IAutenticacaoService autenticacaoService)
		{
			_autenticacaoService = autenticacaoService;
		}

		[HttpGet, Route("nova-conta")]
		public IActionResult Registro()
		{
			return View();
		}

		[HttpPost, Route("nova-conta")]
		public async Task<IActionResult> Registro(UsuarioRegistro usuarioRegistro)
		{
			if (!ModelState.IsValid) return View(usuarioRegistro);

			//API - Registro
			var resposta = await _autenticacaoService.Regitro(usuarioRegistro);

			if (ResponsePossuiErros(resposta.ResponseResult)) return View(usuarioRegistro);

			//Realizar Login na APP
			await RealizarLogin(resposta);

			return RedirectToAction("Index", "Home");
		}

		[HttpGet, Route("login")]
		public IActionResult Login(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			return View();
		}

		[HttpPost, Route("login")]
		public async Task<IActionResult> Login(UsuarioLogin usuarioLogin, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			if (!ModelState.IsValid) return View(usuarioLogin);

			//API - Login
			var resposta = await _autenticacaoService.Login(usuarioLogin);

			if (ResponsePossuiErros(resposta.ResponseResult)) return View(usuarioLogin);

			//Realizar Login na APP
			await RealizarLogin(resposta);

			if (string.IsNullOrEmpty(returnUrl)) return RedirectToAction("Index", "Catalogo");
			
			return LocalRedirect(returnUrl);
		}

		[HttpGet, Route("sair")]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

			return RedirectToAction("Index", "Catalogo");
		}

		private async Task RealizarLogin(UsuarioRespostaLogin resposta)
		{
			var token = ObterTokenFormatado(resposta.AcessoToken);

			var claims = new List<Claim>();
			claims.Add(new Claim("JWT", resposta.AcessoToken));
			claims.AddRange(token.Claims);

			var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

			var authProperties = new AuthenticationProperties
			{
				ExpiresUtc = DateTime.UtcNow.AddMinutes(60),
				IsPersistent = true
			};


			await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
		}

		private static JwtSecurityToken ObterTokenFormatado(string jwtToken)
		{
			return new JwtSecurityTokenHandler().ReadToken(jwtToken) as JwtSecurityToken;
		}
	}
}
