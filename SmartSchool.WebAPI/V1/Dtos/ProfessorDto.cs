using System;
using System.Collections.Generic;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.V1.WebAPI.Dtos
{
    public class ProfessorDto
    {
        public int Id { get; set; }
        public int Registro { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; } = true;
        public IEnumerable<Disciplina> Disciplina { get; set; }
    }
}