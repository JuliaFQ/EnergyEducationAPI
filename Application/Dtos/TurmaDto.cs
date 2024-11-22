using EnergyEducationAPI.Interfaces.Dtos;

namespace EnergyEducationAPI.Application.Dtos
{
    public class TurmaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Ano { get; set; } 
    }
}
