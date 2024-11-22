using AutoMapper;
using Concessionario;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;
        public CaminhaoController(IConfiguration config, ICaminhaoService caminhaoService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = caminhaoService;
        }
        [HttpPost("adicionar-Caminhao")]
        public void AdicionarCaminhao(Caminhao caminhao)
        {
            _service.Adicionar(caminhao);
        }
        [HttpGet("listar-Caminhao")]
        public List<Caminhao> ListarCaminhao()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Caminhao")]
        public void EditarCaminhao(Caminhao cam)
        {
            _service.Editar(cam);
        }
        [HttpDelete("deletar-Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);

        }
    }
}
