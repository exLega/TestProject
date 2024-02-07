using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{
    [Table("pacient")]
    public sealed class PacientModel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("surname")]
        public string Surname { get; set; } = string.Empty;

        [Column("father_name")]
        public string FatherName { get; set; } = string.Empty;

        [Column("gender")]
        public char FatherSurname { get; set; }

        [Column("number_phone")]
        public string NumberPhone {  get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        //cвязь
        public PassportModel? Passport { get; set; }

        public InsurancePolicyModel? InsurancePolicyModel { get; set; }

        public MedicalCartModel? medicalCartModel { get; set; } 

        public AppealsModel? AppealsModel { get; set;}

        public VisitModel? VisitModel { get; set; }

    }
}
