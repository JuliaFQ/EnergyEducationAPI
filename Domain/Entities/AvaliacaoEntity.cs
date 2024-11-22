using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_avaliacao")]
public class Avaliacao
{
    public int Id { get; set; } 
    public int UsuarioId { get; set; }
    public int ModuloId { get; set; }
    public DateTime DataAvaliacao { get; set; } 
    public int Pontuacao { get; set; } 
    // Relacionamento
    public Usuario Usuario { get; set; } = null!;
    public Modulo Modulo { get; set; } = null!;
}
