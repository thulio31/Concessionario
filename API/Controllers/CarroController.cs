using AutoMapper;
using Concessionario;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")] //DataNotation

    public class CarroController : ControllerBase
    {
        private readonly ICarroService _service;
        public CarroController(IConfiguration config, ICarroService carroService)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = carroService;
        }
        [HttpPost("adicionar-Carro")]
        public void AdicionarCarro(Carro Carro)
        {
            _service.Adicionar(Carro);
        }
        [HttpGet("listar-Carro")]
        public List<Carro> ListarCarro()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Carro")]
        public void EditarCarro(Carro p)
        {
            _service.Editar(p);
        }
        [HttpDelete("deletar-Carro")]
        public void DeletarCarro(int id)
        {
            _service.Remover(id);
        }
    }
}
