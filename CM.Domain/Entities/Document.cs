using C4M.Domain.Interfaces;
using MongoDB.Bson;
using System;

namespace C4M.Domain.Entities
{
    public abstract class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreatedAt => Id.CreationTime;
    }
}
