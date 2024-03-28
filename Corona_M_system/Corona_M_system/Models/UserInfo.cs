namespace Corona_M_system.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public string? StreetNum { get; set; }
        public string? PhoneNumber { get; set; }
        public string? CellPhone { get; set; }
        public DateTime? RecoveryDate { get; set; }
        public DateTime? PositiveResult { get; set; }
        public ICollection<Vaccination>? Vaccinations { get; set; }       
    }
}
