using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{

    [Table("medical_cart")]
    public sealed class MedicalCartModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pacient_id")]
        public int PacientId { get; set; }

        [Column("number")]
        public int Number { get; set;}

        [Column("date_issue")]
        public DateTime Date { get; set;}

        //связь
        public PacientModel? Pacient { get; set; }   

        public List<HistoryDiseaseModel> HistoryDiseaseModels { get; set; } = new();
    }
}
