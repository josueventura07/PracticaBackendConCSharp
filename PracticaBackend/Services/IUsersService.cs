using PracticaBackend.DTOs;

namespace PracticaBackend.Services
{
    public interface IUsersService
    {
        public Task<IEnumerable<PersonaDto>> GetAllPeople();
    }
}
