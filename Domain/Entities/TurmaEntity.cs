using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_turma")]
public class Turma
{
    public int Id { get; set; } 
    public string NomeTurma { get; set; } = string.Empty;
    public int Ano { get; set; } 

    // Relacionamento
    public ICollection<Usuario>? Usuarios { get; set; } 
    public ICollection<Modulo>? Modulos { get; set; } 
}
