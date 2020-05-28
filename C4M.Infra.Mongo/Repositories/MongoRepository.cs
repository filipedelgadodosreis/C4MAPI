using C4M.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static C4M.Infra.Mongo.Settings.Settings;

namespace C4M.Infra.Mongo.Repositories
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : IDocument
    {
        private readonly IMongoDatabase _mongoDatabase;
        private IMongoCollection<TDocument> _collection;

        public MongoRepository(IMongoDbSettings settings)
        {
            _mongoDatabase = new MongoClient(settings.ConnectionString).GetDatabase(settings.DatabaseName);
            //_collection = database.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));
        }

        //private protected string GetCollectionName(Type documentType)
        //{
        //    return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
        //            typeof(BsonCollectionAttribute),
        //            true)
        //        .FirstOrDefault())?.CollectionName;
        //}

        public void SetCollection(string collectionName)
        {
            _collection = _mongoDatabase.GetCollection<TDocument>(collectionName);
        }

        public virtual IQueryable<TDocument> AsQueryable()
        {
            return _collection.AsQueryable();
        }

        public virtual Task<IEnumerable<TDocument>> FilterBy(
            Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            //return _collection.Find(filterExpression).ToEnumerable();
            return Task.Run(() => _collection.Find(filterExpression).ToEnumerable());
        }

        public virtual IEnumerable<TProjected> FilterBy<TProjected>(
            Expression<Func<TDocument, bool>> filterExpression,
            Expression<Func<TDocument, TProjected>> projectionExpression, string collectionName)
        {
            SetCollection(collectionName);
            return _collection.Find(filterExpression).Project(projectionExpression).ToEnumerable();
        }

        public virtual TDocument FindOne(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            return _collection.Find(filterExpression).FirstOrDefault();
        }

        public virtual Task<TDocument> FindOneAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            return Task.Run(() => _collection.Find(filterExpression).FirstOrDefaultAsync());
        }

        public virtual TDocument FindById(string id, string collectionName)
        {
            SetCollection(collectionName);

            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);

            return _collection.Find(filter).SingleOrDefault();
        }

        public virtual Task<TDocument> FindByIdAsync(string id, string collectionName)
        {
            SetCollection(collectionName);

            return Task.Run(() =>
            {
                var objectId = new ObjectId(id);
                var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
                return _collection.Find(filter).SingleOrDefaultAsync();
            });
        }


        public virtual void InsertOne(TDocument document, string collectionName)
        {
            SetCollection(collectionName);
            _collection.InsertOne(document);
        }

        public virtual Task InsertOneAsync(TDocument document, string collectionName)
        {
            SetCollection(collectionName);
            return Task.Run(() => _collection.InsertOneAsync(document));
        }

        public void InsertMany(ICollection<TDocument> documents, string collectionName)
        {
            SetCollection(collectionName);
            _collection.InsertMany(documents);
        }


        public virtual async Task InsertManyAsync(IEnumerable<TDocument> documents, string collectionName)
        {
            SetCollection(collectionName);
            await _collection.InsertManyAsync(documents);
        }

        public void ReplaceOne(TDocument document, string collectionName)
        {
            SetCollection(collectionName);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            _collection.FindOneAndReplace(filter, document);
        }

        public virtual async Task ReplaceOneAsync(TDocument document, string collectionName)
        {
            SetCollection(collectionName);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.FindOneAndReplaceAsync(filter, document);
        }

        public void DeleteOne(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            _collection.FindOneAndDelete(filterExpression);
        }

        public Task DeleteOneAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            return Task.Run(() => _collection.FindOneAndDeleteAsync(filterExpression));
        }

        public void DeleteById(string id, string collectionName)
        {
            SetCollection(collectionName);
            var objectId = new ObjectId(id);
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
            _collection.FindOneAndDelete(filter);
        }

        public Task DeleteByIdAsync(string id, string collectionName)
        {
            SetCollection(collectionName);
            return Task.Run(() =>
            {
                var objectId = new ObjectId(id);
                var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, objectId);
                _collection.FindOneAndDeleteAsync(filter);
            });
        }

        public void DeleteMany(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            _collection.DeleteMany(filterExpression);
        }

        public Task DeleteManyAsync(Expression<Func<TDocument, bool>> filterExpression, string collectionName)
        {
            SetCollection(collectionName);
            return Task.Run(() => _collection.DeleteManyAsync(filterExpression));
        }
    }
}
