namespace Entities
{
    public class Nutrient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Measure {  get; set; }

        public Nutrient(int id,
            string name,
            string measure)
        {
            Id = id;
            Name = name;
            Measure = measure;
        }
    }
}
