# 🧮 Desafio

Uma API Web simples em **C# .NET 8** que implementa dois endpoints RESTful (`GET` e `POST`), com boas práticas de desenvolvimento, injeção de dependência e tratamento de erros.

---

## 🚀 Funcionalidades

✅ **GET /api/random**  
Retorna um número aleatório gerado no momento da requisição.

✅ **POST /api/calcular**  
Recebe um DTO com informações de operação matemática (data, nome, valores e operador) e retorna o resultado.

---

## 🧩 Exemplo de DTO

```json
{
  "data": "2025-10-16",
  "nome": "Patrícia",
  "primeiroValor": 8,
  "segundoValor": 2,
  "operador": "/"
}
💡 Exemplos de Requisição
🔹 GET — Número Aleatório
Endpoint: GET /api/random

Resposta:

json
Copiar código
{
  "numeroAleatorio": 472
}
🔹 POST — Operação Matemática
Endpoint: POST /api/calcular

Body (JSON):

json
Copiar código
{
  "data": "2025-10-16",
  "nome": "Patrícia",
  "primeiroValor": 8,
  "segundoValor": 2,
  "operador": "/"
}
Resposta:

json
Copiar código
{
  "data": "2025-10-16T00:00:00",
  "nome": "Patrícia",
  "primeiroValor": 8,
  "segundoValor": 2,
  "operador": "/",
  "resultado": 4
}
⚙️ Tecnologias Utilizadas
🟦 C#

🌐 .NET 8 (Web API)

📦 Swashbuckle.AspNetCore (Swagger)

🧩 Injeção de Dependência

🔒 Tratamento de Exceções

💻 Como Executar o Projeto
Clone o repositório

bash
Copiar código
git clone https://github.com/PatriciaCorlaite/Desafio.git
Acesse a pasta

bash
Copiar código
cd Desafio
Restaure as dependências

bash
Copiar código
dotnet restore
Execute o projeto

bash
Copiar código
dotnet run
Acesse o Swagger
👉 https://localhost:7190/swagger

🧭 Boas Práticas Implementadas
Separação de camadas (Controller, Services, DTOs)

Injeção de dependência nativa do .NET

Tratamento de exceções

Retornos padronizados em JSON

Código limpo e extensível
