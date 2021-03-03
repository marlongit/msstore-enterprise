using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MS.Identidade.API.Controllers
{
	[ApiController]
	public abstract class MainController : Controller
	{
		protected ICollection<string> Erros = new List<string>();
		protected ActionResult CustomResponse(Object result = null)
		{
			if (OperacaoValida())
			{
				return Ok(result);
			}

			return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
			{
				{ "Mensagens", Erros.ToArray() } 
			}));
		}

		protected bool OperacaoValida()
		{
			return !Erros.Any();
		}

		protected ActionResult CustomResponse(ModelStateDictionary modelState)
		{
			var erros = modelState.Values.SelectMany(v => v.Errors);
			foreach (var erro in erros)
			{
				AdicionarErroProcesamento(erro.ErrorMessage);
			}
			return CustomResponse();
		}

		protected void AdicionarErroProcesamento(string erro) => Erros.Add(erro);
		protected void LimparErroProcessamento() => Erros.Clear();

	}
}
