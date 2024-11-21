using AutoMapper;
using Concessionario;
using Core._01Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")] //DataNotation
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;
        private readonly IMapper _mapper; //criando o mapper a ser preenchido

        public CaminhaoController(IMapper mapper, IConfiguration configuration, ICaminhaoService service)
        {
            string _connectionString = configuration.GetConnectionString("DefaultConnection");//Passando a connection para uma nova string
            _mapper = mapper;
            _service = service;
        }

        /// <summary>
        /// endpoint para listar todos os Caminhao do banco de dados
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Listar-caminhao")]// Rota (EndPoint)
        public List<Caminhao> ListarCaminhao()
        {
            return _service.Listar();
        }

        /// <summary>
        /// endpoint que adiciona um Caminhao para o banco de dados
        /// </summary>
        /// <param name="carroDto"></param>
        /// <returns></returns>
        [HttpPost("Adicionar-Caminhao")]// Rota (EndPoint)
        public void AdicionarContrib(Caminhao camoDto) //pegando a dto
        {
            Caminhao caminhao = _mapper.Map<Caminhao>(camoDto);
            _service.Adicionar(caminhao);
        }

        /// <summary>
        /// endpoint que busca um Carro po id no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HttpGet("Buscar-caminhao")]
        public Caminhao BuscarCaminhao(int id)
        {
            return _service.BuscarCaminhaoPorId(id);


        }


        /// <summary>
        ///  endpoint que deleta um caminhao por id inserido
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete-caminhao")]// Rota (EndPoint)
        public void DeleteCaminhao(int id)
        {
            _service.Remover(id);

        }

        /// <summary>
        /// endpoit que edita um caminhao por id inserido
        /// </summary>
        /// <param name="caminhao"></param>
        /// <returns></returns>
        [HttpPut("Editar-Carro")]// Rota (EndPoint)
        public void EditarCarro(Caminhao caminhao)
        {

            _service.Editar(caminhao);

        }
    }
}
