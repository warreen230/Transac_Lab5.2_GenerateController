using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinqEtSeedEF.Models
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int RestaurantId { get; set; }
        [ValidateNever]
        public Restaurant Restaurant { get; set; }
        [ValidateNever]
        public List<CommandePlat> CommandesPlats { get; set; }
    }
}
