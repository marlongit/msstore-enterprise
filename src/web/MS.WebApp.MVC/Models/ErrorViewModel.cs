using System;
using System.Collections.Generic;

namespace MS.WebApp.MVC.Models
{
	public class ErrorViewModel
	{
		public int ErroCode { get; set; }
		public string Titulo { get; set; }
		public string Mensagem { get; set; }

	}
	public class ResponseResult
	{
		public string Title { get; set; }
		public int Status { get; set; }
		public ResponseErrorMenssages Errors { get; set; }	
	}

	public class ResponseErrorMenssages
	{
		public List<string> Mensagens { get; set; }
	}
}
