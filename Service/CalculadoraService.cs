using System;
using Desafio.DTOs;

namespace Desafio.Services
{
    public class CalculadoraService : ICalculadoraService
    {
        public OperacaoDTO Calcular(OperacaoDTO dto)
        {
            double resultado;

            switch (dto.Operador)
            {
                case "+":
                    resultado = dto.PrimeiroValor + dto.SegundoValor;
                    break;
                case "-":
                    resultado = dto.PrimeiroValor - dto.SegundoValor;
                    break;
                case "*":
                    resultado = dto.PrimeiroValor * dto.SegundoValor;
                    break;
                case "/":
                    if (dto.SegundoValor == 0)
                        throw new DivideByZeroException("Não é possível dividir por zero.");
                    resultado = dto.PrimeiroValor / dto.SegundoValor;
                    break;
                default:
                    throw new ArgumentException("Operador inválido. Use +, -, * ou /.");
            }

            dto.Resultado = resultado;
            return dto;
        }
    }
}