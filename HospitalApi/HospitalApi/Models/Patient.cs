using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models
{
    public class Patient
    {
        [Key]
        public int codPaciente { get; set; }

        [StringLength(50)]
        public string nomePaciente { get; set; }

        [StringLength(2)]
        public string sexoPaciente { get; set; }

        public DateTime dataNascimento { get; set; }

        [StringLength(50)]
        public string nomeMaePaciente { get; set; }

        [StringLength(11)]
        public string cpfPaciente { get; set; }

        [StringLength(9)]
        public string rgPaciente { get; set; }

        [StringLength(15)]
        public string cns { get; set; }

        [StringLength(15)]
        public string corPaciente { get; set; }

        [StringLength(30)]
        public string nacionalidade { get; set; }

        [StringLength(30)]
        public string naturalidade { get; set; }

        [StringLength(50)]
        public string grauInstrucaoPaciente { get; set; }

        [StringLength(50)]
        public string profissaoPaciente { get; set; }

        [StringLength(30)]
        public string responsavelPaciente { get; set; }

        [StringLength(10)]
        public string cep { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }

        [StringLength(50)]
        public string bairro { get; set; }

        [StringLength(30)]
        public string cidade { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(10)]
        public string telefone { get; set; }

        [StringLength(11)]
        public string celular { get; set; }

        [StringLength(30)]
        public string contato { get; set; }

        [StringLength(10)]
        public string telefoneContato { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(500)]
        public string observacao { get; set; }
    }
}
