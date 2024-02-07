using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProject.Models
{

    [Table("pasport")]
    public sealed class PassportModel 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("pacient_id")]
        public int PacientId { get; set; }

        [Column("number_pasport")]
        public string NumberPassport { get; set; } = string.Empty;

        [Column("seria_pasport")]
        public string SeriaPassport { get; set; } = string.Empty;

        [Column("date_birth")]
        public DateTime DateBirth { get; set; }

        [Column("address")]
        public string Address { get; set; } = string.Empty;

        [Column("photo_file_name")]
        public string PhotoFileName { get; set; } = string.Empty;

        //связь
        public PacientModel? Pacient { get; set; }

    }
}
