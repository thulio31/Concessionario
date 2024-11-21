using AutoMapper;
using Concessionario;
using Core._01Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")] //DataNotation

    public class CarroController : ControllerBase
    {
        private readonly ICarroService _service;
        private readonly IMapper _mapper;
        public CarroController(IConfiguration config, IMapper mapper, ICarroService service)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = service;
            _mapper = mapper;
        }
        [HttpPost("adicionar-carro")]
        public void AdicionarAluno(Carro carroDTO)
        {
            Carro carro = _mapper.Map<Carro>(carroDTO);
            _service.Adicionar(carro);
        }
        [HttpGet("listar-produto")]
        public List<Carro> ListarCarro()
        {
            return _service.Listar();
        }
        [HttpPut("editar-carro")]
        public void EditarProduto(Carro c)
        {
            _service.Editar(c);
        }
        [HttpDelete("deletar-carro")]
        public void DeletarCarro(int id)
        {
            _service.Remover(id);
        }
    }
}
