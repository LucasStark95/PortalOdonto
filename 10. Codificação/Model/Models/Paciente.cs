using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model.Models
{
    public class Paciente
    {
        public List<string> tipoSexo = new List<string>();
        public List<string> tipoEstadoCivil = new List<string>();
        private string nomePaciente;
        private string enderecoPaciente;
        private string cpfPaciente;
        private string rgPaciente;
        private string responsavelPaciente;
        private DateTime dtNascimentoPaciente;
        private string sexo;
        private string naturalidade;
        private string estado;
        private string nacionalidade;
        private string estadoCivil;
        private string raca;
        private string religiao;
        private double peso;
        private double altura;
        private string grauDeInstrucao;
        private string pai;
        private string mae;
        private string nacionalidadePai;
        private string nacionalidadeMae;
        private string profissao;
        private string zona;
        private string contato;
        private string cidade;
        private double pressaoArterial;
        private double batimentoCardiaco;
        private int idPaciente;       

        public Paciente()
        {
            this.tipoSexo = new List<string>();
            this.tipoEstadoCivil = new List<string>();
            tipoSexo.Add("Feminino");
            tipoSexo.Add("Masculino");

            tipoEstadoCivil.Add("Casado(a)");
            tipoEstadoCivil.Add("Solteiro(a)");
            tipoEstadoCivil.Add("Divorciado(a)");
            tipoEstadoCivil.Add("Vi�vo(a)");
        }

        [Required (ErrorMessage = "Campo Obrigat�rio")]
        [Display (Name = "ID Paciente")]
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [Display (Name = "Nome Completo")]
        [StringLength (60, MinimumLength = 2)]
        public string NomePaciente
        {
            get { return nomePaciente; }
            set { nomePaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [StringLength(14, MinimumLength = 2)]
        [Display (Name = "RG")]
        public string RgPaciente
        {
            get
            { return rgPaciente; }
            set { rgPaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [StringLength(15, MinimumLength = 11)]
        [Display(Name = "CPF")]
        public string CpfPaciente
        {
            get { return cpfPaciente; }
            set { cpfPaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [Display (Name = "Endere�o")]
        [StringLength(60, MinimumLength = 2)]
        public string EnderecoPaciente
        {
            get { return enderecoPaciente; }
            set { enderecoPaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [Display (Name = "Responsavel")]
        public string ResponsavelPaciente
        {
            get { return responsavelPaciente; }
            set { responsavelPaciente = value; }
        }

        [Required(ErrorMessage = "Campo Obrigat�rio")]
        [DataType(DataType.Date)]
        [Display(Name = "Data Nascimento")] 
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Dt_nascimentoPaciente
        {
            get { return dtNascimentoPaciente; }
            set { dtNascimentoPaciente = value; }
        }

        [Display(Name = "Sexo")]
        [StringLength(10, MinimumLength = 1)]
        public string Sexo
        {
            get { return sexo ; }
            set { sexo = value; }
        }

        [Display (Name = "Naturalidade")]
        [StringLength(40, MinimumLength = 2)]
        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }

        [Display(Name = "Estado")]
        [StringLength(40, MinimumLength = 2)]
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        [Display(Name = "Nacionalidade")]
        [StringLength(40, MinimumLength = 2)]
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        [Display(Name = "Estado Civil")]
        [StringLength(40, MinimumLength = 2)]
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }

        [Display(Name = "Ra�a")]
        [StringLength(40, MinimumLength = 2)]
        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }

        [Display(Name = "Religi�o")]
        [StringLength(40, MinimumLength = 2)]
        public string Religiao
        {
            get { return religiao; }
            set { religiao = value; }
        }

        [Display(Name = "Peso")]
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        [Display(Name = "Altura")]
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        [Display(Name = "Escolaridade")]
        [StringLength(40, MinimumLength = 2)]
        public string GrauDeInstrucao
        {
            get { return grauDeInstrucao; }
            set { grauDeInstrucao = value; }
        }

        [Display(Name = "Pai")]
        [StringLength(60, MinimumLength = 2)]
        public string Pai
        {
            get { return pai; }
            set { pai = value; }
        }

        [Display(Name = "M�e")]
        [StringLength(60, MinimumLength = 2)]
        public string Mae
        {
            get { return mae; }
            set { mae = value; }
        }

        [Display(Name = "Nacionalidade do Pai")]
        [StringLength(40, MinimumLength = 2)]
        public string NacionalidadePai
        {
            get { return nacionalidadePai; }
            set { nacionalidadePai = value; }
        }

        [Display(Name = "Nacionalidade da M�e")]
        [StringLength(40, MinimumLength = 2)]
        public string NacionalidadeMae
        {
            get { return nacionalidadeMae; }
            set { nacionalidadeMae = value; }
        }

        [Display(Name = "Profiss�o")]
        [StringLength(40, MinimumLength = 2)]
        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        [Display(Name = "Zona")]
        [StringLength(40, MinimumLength = 2)]
        public string Zona
        {
            get { return zona; }
            set { zona = value; }
        }

        [Display(Name = "Contato")]
        [StringLength(20, MinimumLength = 2)]
        public string Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        [Display(Name = "Cidade")]
        [StringLength(60, MinimumLength = 2)]
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        [Display(Name = "Press�o Arterial")]
        public double PressaoArterial
        {
            get { return pressaoArterial; }
            set { pressaoArterial = value; }
        }

        [Display(Name = "Batimento Cardiaco")]
        public double BatimentoCardiaco
        {
            get { return batimentoCardiaco; }
            set { batimentoCardiaco = value; }
        }      
    }
}