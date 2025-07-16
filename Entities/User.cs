namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public int? DiagnosticId { get; set; }
        public ICollection<Recomdendation> Recomdendations { get; set; }
        public Diagnostic Diagnostic { get; set; }

        public User(int id, int? diagnosticId) 
        { 
            Id = id;
            DiagnosticId = diagnosticId;
        }
    }
}
