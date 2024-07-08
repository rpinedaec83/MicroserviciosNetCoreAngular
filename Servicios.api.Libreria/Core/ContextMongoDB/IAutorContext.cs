using MongoDB.Driver;
using Servicios.api.Libreria.Core.Entities;

namespace Servicios.api.Libreria.Core.ContextMongoDB
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
