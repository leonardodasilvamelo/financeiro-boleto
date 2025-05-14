# Financeiro.Boleto

Sistema de gerenciamento de boletos financeiros desenvolvido em .NET Core utilizando arquitetura limpa (Clean Architecture).

## Estrutura do Projeto

O projeto está organizado nas seguintes camadas:

- **Financeiro.Boleto.Domain**: Contém as entidades de domínio, interfaces e regras de negócio.
- **Financeiro.Boleto.Application**: Implementação dos casos de uso da aplicação.
- **Financeiro.Boleto.Infra.Data**: Camada de acesso a dados e implementações de repositórios.
- **Financeiro.Boleto.Infra.IoC**: Configuração de injeção de dependências.
- **Financeiro.Boleto.WebUI**: Interface de usuário web.
- **Financeiro.Boleto.API**: API REST para comunicação externa.
- **Financeiro.Boleto.Domain.Test**: Testes unitários para o domínio.

## Configuração

1. Certifique-se de ter o .NET SDK instalado
2. Clone o repositório
3. Restaure os pacotes NuGet
4. Configure a conexão com o banco de dados
5. Execute as migrações para criar o banco de dados
6. Execute o projeto

## Tecnologias Utilizadas

- .NET Core
- Entity Framework Core
- ASP.NET Core MVC
- ASP.NET Core Web API
- Injeção de Dependência nativa
- SQL Server