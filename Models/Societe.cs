using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace store.Models
{
    public class Societe
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string RaisonSocial { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Acitivite { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Adresse { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string MF { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string NumTel { get; set; } = "";
        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Rib { get; set; } = "";
        public byte[] logo { get; set; }
        [NotMapped]
        public string LogoUrl { get; set; }

    }
}
