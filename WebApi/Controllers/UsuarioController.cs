using LogicaAplicacion.Usuarios;
using LogicaDeNegocio.Entidades;
using LogicaDeNegocio.IntefacesServicios;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private ILogin<Usuario> _login;

        public UsuarioController(ILogin<Usuario> login)
        {
            _login = login;
        }
        [HttpPost]
        public IActionResult Token(UserDto dto)
        {
            try
            {
                Usuario usuario = _login.Ejecutar(dto.Email, dto.Pass);
                var token = ManejadorJwt.GenerarToken(usuario);
                return Ok(token);
            }catch (Exception)
            {
                return BadRequest("Los datos recibidos no son correctos");
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult Login(UserDto dto)
        {
            try
            {
                Usuario usuario = _login.Ejecutar(dto.Email, dto.Pass);
                return Ok(usuario);
            }
            catch (Exception)
            {
                return BadRequest("Los datos recibidos no son correctos");
            }
        }
    }
}
