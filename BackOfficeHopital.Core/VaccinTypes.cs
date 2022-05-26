using System.Collections.Generic;

namespace BackOfficeHopital.Core
{
    public class VaccinTypes
    {
        public string id { get; set; }
        public string nom { get; set; }
        public int stock { get; set; }
        

        public VaccinTypes(string id, string nom, int stock)
        {
            this.id = id;
            this.nom = nom;
            this.stock = stock;

        }

        public override string ToString()
        {
            return $"Nom : {nom} - Stock : {stock}";
        }
    }
}