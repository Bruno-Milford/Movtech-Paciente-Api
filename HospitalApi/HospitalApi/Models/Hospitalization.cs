using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models
{
    public class Hospitalization
    {
        [Key]
        public int codInternacao { get; set; }

        public int codPaciente { get; set; } 

        [StringLength(50)]
        public string Paciente { get; set; }

        public DateTime Nascimento { get; set; }

        [StringLength(50)]
        public string MaePaciente { get; set; }

        public DateTime dataEntradaInternacao { get; set; }

        public DateTime dataSaidaInternacao { get; set; }

        [StringLength(15)]
        public string cns { get; set; }

        [StringLength(50)]
        public string ClinicaMedica { get; set; }

        [StringLength(50)]
        public string localizacao { get; set; }

        [StringLength(30)]
        public string leito { get; set; }

        [StringLength(50)]
        public string centroCusto { get; set; }

        [StringLength(500)]
        public string hipoteseDiagnostica { get; set; }

        [StringLength(50)]
        public string medico { get; set; }

        [StringLength(6)]
        public string crm { get; set; }

        [StringLength(500)]
        public string diagnostico { get; set; }

        [StringLength(10)]
        public string situacao { get; set; }
    }
}
