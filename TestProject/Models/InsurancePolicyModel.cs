using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
    [Table("insurance_policy")]
    public sealed class InsurancePolicyModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pacient_id")]
        public int PacientId { get; set; }

        [Column("number")]
        public int Number { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        public PacientModel? Pacient { get; set; }
    }
}
