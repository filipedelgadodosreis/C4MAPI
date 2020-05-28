using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace C4M.Domain.Interfaces
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        void SetCollection(string collectionName);

        IQueryable<TDocument> AsQueryable();

        Task<IEnumerable<TDocument>> FilterBy(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        IEnumerable<TProjected> FilterBy<TProjected>(Expression<Func<TDocument, bool>> filterExpression, Expression<Func<TDocument, TProjected>> projectionExpression, string collectionName);

        TDocument FindOne(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        TDocument FindById(string id, string collectionName);

        Task<TDocument> FindByIdAsync(string id, string collectionName);

        void InsertOne(TDocument document, string collectionName);

        Task InsertOneAsync(TDocument document, string collectionName);

        void InsertMany(ICollection<TDocument> documents, string collectionName);

        Task InsertManyAsync(IEnumerable<TDocument> documents, string collectionName);

        void ReplaceOne(TDocument document, string collectionName);

        Task ReplaceOneAsync(TDocument document, string collectionName);

        void DeleteOne(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        void DeleteById(string id, string collectionName);

        Task DeleteByIdAsync(string id, string collectionName);

        void DeleteMany(Expression<Func<TDocument, bool>> filterExpression, string collectionName);

        Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName);
    }
}
