using System;

namespace SmartSchool.WebAPI.V2.Dtos
{
    public class AlunoDto
    {
        /// <summary>
        /// Identificador e chave do Banco
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do Aluno, para outros negócios na Instituição
        /// </summary>
        public int Matricula { get; set; }
        /// <summary>
        /// Nome é o primeiro nome e sobrenome do aluno
        /// </summary>
        public string Nome { get; set; }
        public string Telefone { get; set; }
        /// <summary>
        /// Esta idade é o cálculo relacionado a data de nascimento do Aluno
        /// </summary>
        public int idade { get; set; }
        public DateTime DataIni { get; set; }
        public bool Ativo { get; set; }
    }
}