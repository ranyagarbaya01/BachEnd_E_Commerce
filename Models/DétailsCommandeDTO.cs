namespace store.Models
{
    public class DétailsCommandeDTO
    {
        public int Id { get; set; }
        public int Qte { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal PrixTotal { get; set; }
        public int idProduit { get; set; }
    }
}
