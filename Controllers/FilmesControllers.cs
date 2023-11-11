using AutoMapper;
using CrudWebApiAspCore.Models;
using CrudWebApiAspCore.Service;
using Microsoft.AspNetCore.Mvc;

namespace CrudWebApiAspCore.Controllers
{
    [Route("filmes")]
    public class FilmesController : Controller
    {
        private readonly IFilmeService service;
        private readonly IMapper  _mapper;

        public FilmesController(IFilmeService service, IMapper mapper)
        {
            this.service = service;
            this._mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetFilmes();
            var resultDto  = _mapper.Map<List<FilmeDto>>(result); 
            return Ok(resultDto);
        }

        [HttpGet("{id}", Name = "GetFilme")]
        public IActionResult Get(int id)
        {
            var result = service.GetFilme(id);

            if (result is null)
                return NotFound();
            
            var resultMap = _mapper.Map<FilmeDto>(result);
            
            return Ok(resultMap);
        }
        
        [HttpPost]
        public IActionResult Create([FromBody] FilmeDto inputModel)
        {
            if (inputModel == null)
                return BadRequest();
            
            var model = this._mapper.Map<Filme>(inputModel);
            service.AddFilme(model);

            var outputModel = _mapper.Map<FilmeDto>(model);
            return CreatedAtRoute("GetFilme", new { id = outputModel.Id }, outputModel);
        }
        
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] FilmeDto inputModel)
        {
            if (inputModel == null || id != inputModel.Id)
                return BadRequest();

            if (!service.FilmeExists(id))
                return NotFound();
            
            var model = _mapper.Map<Filme>(inputModel);

            service.UpdateFilme(model);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!service.FilmeExists(id))
                return NotFound();

            service.DeleteFilme(id);
            return Ok();
        }
    }
}
