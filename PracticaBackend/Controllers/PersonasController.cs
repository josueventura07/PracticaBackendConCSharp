using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaBackend.DTOs;
using PracticaBackend.Models;
using PracticaBackend.Services;

namespace PracticaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private IUsersService _usersService;

        public PersonasController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonaDto>> GetPersonas() =>
            await _usersService.GetAllPeople(); 
          
        

    }

}
