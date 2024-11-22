using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyEducationAPI.Domain.Entities;

[Table("tb_progressoestudante")]
public class ProgressoEstudante
{
    public int Id { get; set; } // Chave primária
    public int UsuarioId { get; set; }
    public int ModuloId { get; set; }
    public int AtividadeId { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int PontuacaoFinal { get; set; } // Pontos obtidos na atividade

    // Relacionamento
    public Usuario Usuario { get; set; } = null!;
    public Modulo Modulo { get; set; } = null!;
    
}
