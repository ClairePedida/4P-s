using System.ComponentModel.DataAnnotations;
namespace PantawidPamilya._4ps
{
    public class Class
    {
        public int ID { get; set; }
        public string Barangay { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int Beneficiaries  { get; set; }
    }
}
