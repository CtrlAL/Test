namespace Entities
{
    internal class PersonalSuggestion : IEntity<int>
    {
        public int Id { get ; set; }
        public int DiagnosticId { get ; set; }
        public Diagnostic Diagnostic { get; set; }
        public ICollection<Product> Products { get; set; }

        public PersonalSuggestion(int id,
            int diagnosticId)
        {
            Id = id;
            DiagnosticId = diagnosticId;
        }
    }
}
