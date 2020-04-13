using C4M.Domain.Attributes;
using System;

namespace C4M.Domain.Entities
{
    [BsonCollection("people")]
    public class Person : Document
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
