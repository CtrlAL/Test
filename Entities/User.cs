﻿namespace Entities
{
    public class User : IEntity<int>
    {
        public int Id { get; set; }
        public int? DiagnosticId { get; set; }
        public ICollection<Recommendation> Recommendations { get; set; }
        public Diagnostic Diagnostic { get; set; }

        public User(int id, int? diagnosticId) 
        { 
            Id = id;
            DiagnosticId = diagnosticId;
        }
    }
}
