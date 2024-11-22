using EnergyEducationAPI.Interfaces.Dtos;

namespace EnergyEducationAPI.Application.Dtos
{
    public class ProgressoEstudanteDto
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; } 
        public int ModuloId { get; set; } 
        public double Progresso { get; set; } 
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
