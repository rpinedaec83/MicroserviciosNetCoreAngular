﻿using Servicios.api.Libreria.Core.Entities;
using System.Linq.Expressions;

namespace Servicios.api.Libreria.Repository
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {

        Task<IEnumerable<TDocument>> GetAll();
        Task<TDocument> GetById(string id);
        Task InsertDocument(TDocument document);
        Task UpdateDocument(TDocument document);
        Task DeleteById(string id);

        Task<PaginationEntity<TDocument>> PaginationBy(
            Expression<Func<TDocument, bool>> filterExpression,
            PaginationEntity<TDocument> pagination
            );

        Task<PaginationEntity<TDocument>> PaginationByFilter(
            PaginationEntity<TDocument> pagination
            );
    }
}
