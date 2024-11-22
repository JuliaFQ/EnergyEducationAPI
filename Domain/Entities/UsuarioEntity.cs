﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_usuario")]
public class Usuario
{
    public int Id { get; set; } 
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public string TipoUsuario { get; set; } = string.Empty; 
    public DateTime DataCadastro { get; set; }
    
    
    public ICollection<Turma>? Turmas { get; set; } 
    public ICollection<ProgressoEstudante>? Progresso { get; set; }
}

