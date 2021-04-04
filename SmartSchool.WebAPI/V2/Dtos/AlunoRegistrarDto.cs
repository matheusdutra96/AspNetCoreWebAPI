using System;

namespace SmartSchool.WebAPI.V2.Dtos
{
    /// <summary>
    /// Este é o DTO de Aluno para Registrar.
    /// </summary>
    public class AlunoRegistrarDto
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
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataIni { get; set; } = DateTime.Now;
        public DateTime? DataFim { get; set; } = null;
        public bool Ativo { get; set; } = true;
    }
}