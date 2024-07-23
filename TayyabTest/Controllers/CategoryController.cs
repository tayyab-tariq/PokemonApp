using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TayyabTest.Dto;
using TayyabTest.Interfaces;
using TayyabTest.Models;
using TayyabTest.Repository;

namespace TayyabTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICatogoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICatogoryRepository categoryRepository, IMapper mapper)
        { 
            _categoryRepository = categoryRepository;   
            _mapper = mapper;
        }

        [HttpGet(Name = "get_all_categories")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Category>))]
        public ActionResult GetCategories()
        {
            var categories = _mapper.Map<List<CategoryDto>>(_categoryRepository.GetCategories());
                
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categories);
        }

        [HttpGet("{catId}")]
        [ProducesResponseType(200, Type = typeof(Category))]
        [ProducesResponseType(400)]
        public ActionResult GetCategory(int catId) 
        {
            if (!_categoryRepository.CategoryExists(catId))
                return NotFound();

            var category = _mapper.Map<CategoryDto>(_categoryRepository.GetCategory(catId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(category);
        }


        [HttpGet("pokemons/{catId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        [ProducesResponseType(400)]
        public ActionResult GetPokemonsByCategory(int catId)
        {

            if (!_categoryRepository.CategoryExists(catId))
                return NotFound();

            var pokemons = _mapper.Map<List<PokemonDto>>( _categoryRepository.GetPokemonsByCategory(catId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(pokemons);
        }
    }
}
