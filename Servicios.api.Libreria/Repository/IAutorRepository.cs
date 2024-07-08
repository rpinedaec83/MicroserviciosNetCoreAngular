using Servicios.api.Libreria.Core.Entities;

namespace Servicios.api.Libreria.Repository
{
    public interface IAutorRepository
    {
        Task<IEnumerable<Autor>> GetAutores();
    }
}
