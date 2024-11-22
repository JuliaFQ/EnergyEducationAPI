using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_modulo")]
public class Modulo
{
    public int Id { get; set; } 
    public string Titulo { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public int Nivel { get; set; } 

    // Relacionamento
    public ICollection<Conteudo>? Conteudos { get; set; } 
    public ICollection<Turma>? Turmas { get; set; } 
}
