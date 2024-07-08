using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios.api.Libreria.Core.Entities;
using Servicios.api.Libreria.Repository;

namespace Servicios.api.Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly IMongoRepository<LibroEntity> _libroRepository;
        public LibroController(IMongoRepository<LibroEntity> libroRepository)
        {
            _libroRepository = libroRepository;
        }

        [HttpPost]
        public async Task Post(LibroEntity libro) {
            await _libroRepository.InsertDocument(libro);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LibroEntity>>> Get() { 
        
            return Ok(await _libroRepository.GetAll());
        }

        [HttpPost]
        public async Task<ActionResult<PaginationEntity<LibroEntity>>> PostPagination(PaginationEntity<LibroEntity> pagination) { 
            var resultado = await _libroRepository.PaginationByFilter(pagination);
            return Ok(resultado);   
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LibroEntity>> GetById(string id) { 
        
            var libro = _libroRepository.GetById(id);
            return Ok(libro);
        }
    }
}
