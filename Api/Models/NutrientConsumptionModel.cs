using Entities;

namespace Api.Models
{
    public class NutrientConsumptionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Count { get; set; }

        public static NutrientConsumptionModel FromEntity(NutrientConsumption entity)
        {
            return new NutrientConsumptionModel
            {
                Id = entity.Id,
                Name = entity.Nutrient.Name,
                Count = entity.Count,
            };
        }
    }
}
