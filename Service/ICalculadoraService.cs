using Desafio.DTOs;

namespace Desafio.Services
{
    public interface ICalculadoraService
    {
        OperacaoDTO Calcular(OperacaoDTO dto);
    }
}