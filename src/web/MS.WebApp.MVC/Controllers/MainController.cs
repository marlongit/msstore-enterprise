﻿using Microsoft.AspNetCore.Mvc;
using MS.WebApp.MVC.Models;
using System.Linq;

namespace MS.WebApp.MVC.Controllers
{
	public class MainController : Controller
	{
		protected bool ResponsePossuiErros(ResponseResult resposta)
		{
			if (resposta != null && resposta.Errors.Mensagens.Any())
			{
				foreach (var mensagem in resposta.Errors.Mensagens)
				{
					ModelState.AddModelError(string.Empty, mensagem);
				}

				return true;
			}

			return false;
		}
	}
}