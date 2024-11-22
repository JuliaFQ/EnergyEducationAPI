using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_atividade")]
public class Atividade
{
    public int Id { get; set; } 
    public string Descricao { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty; 
    public int ModuloId { get; set; }

    // Relacionamento
    public Conteudo Conteudo { get; set; } = null!;

}
