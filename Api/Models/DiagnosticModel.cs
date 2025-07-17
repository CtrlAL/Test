using Entities;

namespace Api.Models
{
    public class DiagnosticModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public IEnumerable<NutrientConsumptionModel> NutrientConsumptions { get; set; }

        public static DiagnosticModel FromEntity(Diagnostic entity)
        {
            return new DiagnosticModel
            {
                Id = entity.Id,
                UserId  = entity.UserId,
                NutrientConsumptions = entity.NutrientConsumptions.Select(NutrientConsumptionModel.FromEntity)
            };
        }
    }
}
