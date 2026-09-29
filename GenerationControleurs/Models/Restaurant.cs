using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LinqEtSeedEF.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Telephone { get; set; }
        [ValidateNever]
        public List<Commande> Commandes { get; set; }
        [ValidateNever]
        public List<Plat> Plats { get; set; }
    }
}
