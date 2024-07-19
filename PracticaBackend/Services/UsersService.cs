using Microsoft.EntityFrameworkCore;
using PracticaBackend.DTOs;
using PracticaBackend.Models;

namespace PracticaBackend.Services
{
    public class UsersService : IUsersService
    {
        private UsersCrudContext _context;
        public UsersService(UsersCrudContext context) 
        { 
            _context = context; 
        }

        public async Task<IEnumerable<PersonaDto>> GetAllPeople() => 
            await _context.Users.Select(user => new PersonaDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Pass = user.Pass,
                Email = user.Email
            }).ToListAsync();

    }
}
