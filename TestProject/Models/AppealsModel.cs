using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{

    [Table("appeals")]
    public sealed class AppealsModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pacient_id")]
        public int PacientId { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        public List<PacientModel> Pacients { get; set; } = new();
    }
}
