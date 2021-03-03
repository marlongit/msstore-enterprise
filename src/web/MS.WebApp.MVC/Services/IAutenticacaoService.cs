using MS.WebApp.MVC.Models;
using System.Threading.Tasks;

namespace MS.WebApp.MVC.Services
{
	public interface IAutenticacaoService
	{
		Task<UsuarioRespostaLogin> Login(UsuarioLogin usuarioLogin);
		Task<UsuarioRespostaLogin> Regitro(UsuarioRegistro usuarioRegistro );
	}
}
