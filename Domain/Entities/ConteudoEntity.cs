using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_conteudo")]
public class Conteudo
{
    public int Id { get; set; } 
    public string Tipo { get; set; } = string.Empty; 
    public string Descricao { get; set; } = string.Empty; 
    public int ModuloId { get; set; }

    // Relacionamento
    public Modulo Modulo { get; set; } = null!;
    public ICollection<Atividade>? Atividades { get; set; }
}
