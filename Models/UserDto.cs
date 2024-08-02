namespace store.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FullName { get; set; } = "";

        public string Email { get; set; } = "";

        public string Password { get; set; } = "";

        public string PhoneNumber { get; set; } = "";

        public int type { get; set; } = 0;
        public string? token { get; set; } = "";

        public string? NomRaisonSocial { get; set; } = "";
        public string? MFcin { get; set; } = "";
        public string? Adresse { get; set; } = "";
        public string? CodePostal { get; set; } = "";
        public string? Gouvernorat { get; set; } = "";




    }
}
