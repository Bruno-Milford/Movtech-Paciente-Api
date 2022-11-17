using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacienteDLL.Patients
{
    [JsonObject()]
    [Table("MvtBIBPaciente")]

    internal class Patient
    {
        [JsonProperty()]
        [Key]
        public int codPaciente { get; set; }

        [JsonProperty()]
        public string nomePaciente { get; set; }

        [JsonProperty()]
        public string sexoPaciente { get; set; }

        [JsonProperty()]
        [Key]
        public DateOnly dataNascimento { get; set; }

        [JsonProperty()]
        public string nomeMaePaciente { get; set; }

        [JsonProperty()]
        [Key]
        public string cpfPaciente { get; set; }

        [JsonProperty()]
        [Key]
        public string rgPaciente { get; set; }

        [JsonProperty()]
        [Key]
        public string cns { get; set; }

        [JsonProperty()]
        public string corPaciente { get; set; }

        [JsonProperty()]
        public string nacionalidade { get; set; }

        [JsonProperty()]
        public string naturalidade { get; set; }

        [JsonProperty()]
        public string grauInstrucaoPaciente { get; set; }

        [JsonProperty()]
        public string profissaoPaciente { get; set; }

        [JsonProperty()]
        public string responsavelPaciente { get; set; }

        [JsonProperty()]
        public string cep { get; set; }

        [JsonProperty()]
        public string endereco { get; set; }

        [JsonProperty()]
        public string bairro { get; set; }

        [JsonProperty()]
        public string cidade { get; set; }

        [JsonProperty()]
        public string uf { get; set; }

        [JsonProperty()]
        public string telefone { get; set; }

        [JsonProperty()]
        public string celular { get; set; }

        [JsonProperty()]
        public string contato { get; set; }

        [JsonProperty()]
        public string telefoneContato { get; set; }

        [JsonProperty()]
        public string email { get; set; }

        [JsonProperty()]
        public string observacao { get; set; }

        [JsonConstructor()]
        public Patient() {}

        public Patient(int codPaciente, string nomePaciente, string sexoPaciente, DateOnly dataNascimento, string nomeMaePaciente, string cpfPaciente, string rgPaciente,
            string cns, string corPaciente, string nacionalidade, string naturalidade, string grauInstrucaoPaciente, string profissaoPaciente, string responsavelPaciente, 
            string cep, string endereco, string bairro, string cidade, string uf, string telefone, string celular, string contato, string telefoneContato, string email,
            string observacao)
        {
            this.codPaciente = codPaciente;
            this.nomePaciente = nomePaciente;
            this.sexoPaciente = sexoPaciente;
            this.dataNascimento = dataNascimento;
            this.nomeMaePaciente = nomeMaePaciente;
            this.cpfPaciente = cpfPaciente;
            this.rgPaciente = rgPaciente;
            this.cns = cns;
            this.corPaciente = corPaciente;
            this.nacionalidade = nacionalidade;
            this.naturalidade = naturalidade;
            this.grauInstrucaoPaciente = grauInstrucaoPaciente;
            this.profissaoPaciente = profissaoPaciente;
            this.responsavelPaciente = responsavelPaciente;
            this.cep = cep;
            this.endereco = endereco;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.telefone = telefone;
            this.celular = celular;
            this.contato = contato;
            this.telefoneContato = telefoneContato;
            this.email = email;
            this.observacao = observacao;
        }
    }
}
