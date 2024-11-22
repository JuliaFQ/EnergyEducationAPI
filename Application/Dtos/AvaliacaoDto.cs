using EnergyEducationAPI.Interfaces.Dtos;

namespace EnergyEducationAPI.Application.Dtos
{
    public class AvaliacaoDto
    {
        public int Id { get; set; }
        public int ModuloId { get; set; } 
        public double Pontuacao { get; set; }
        public DateTime DataAvaliacao { get; set; }
    }
}
