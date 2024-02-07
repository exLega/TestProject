using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{

    [Table("history_disease")]
    public sealed class HistoryDiseaseModel
    {

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("disease")]
        public string Disease { get; set; } = string.Empty;

        [Column("medical_cart_id")]
        public int MedicalCartId { get; set; }

        public MedicalCartModel? MedicalCart { get; set; }

    }
}
