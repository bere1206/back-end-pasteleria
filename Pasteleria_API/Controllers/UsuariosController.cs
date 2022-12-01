using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pasteleria_API.Services;

namespace Pasteleria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public PasteleriaService _usuarioService;
        public UsuariosController(PasteleriaService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet]
    }
}
