# Aplicação de Autenticação com JWT e Autorização via Roles

## Descrição

Esta aplicação demonstra os conceitos de autenticação utilizando JWT (JSON Web Tokens) e autorização por meio de roles incorporadas ao token. O objetivo é fornecer um exemplo claro e funcional de como implementar autenticação simples com JWT, gerenciar acesso através de roles e configurar o projeto de forma modular e organizada.

### Funcionalidades

- **Autenticação JWT**: Implementação de autenticação com JWT, incluindo claims padrões e roles para gerenciamento de acesso.
- **Autorização por Roles**: Gerenciamento de acesso baseado em roles definidas nas claims do token JWT.
- **Segregação de Responsabilidades**: Arquitetura simples e modular que separa claramente as responsabilidades.
- **Injeção de Dependências**: Configuração de um container de injeção de dependências para gerenciamento de serviços.
- **Configuração e Consumo de Variáveis de Ambiente**: Uso de variáveis de ambiente para configuração da aplicação.
- **Filtros do ASP.NET**: Implementação e uso de filtros do ASP.NET, que oferecem um comportamento semelhante aos middlewares.

## Estrutura do Projeto

- **Controllers**: Contém os controladores da aplicação que lidam com as requisições HTTP.
- **Services**: Contém a lógica de negócios e serviços da aplicação.
- **Models**: Contém as classes de modelos usadas pela aplicação.
- **Configurations**: Contém a configuração do JWT e outras configurações da aplicação.
- **Filters**: Contém filtros personalizados para processamento de requisições.

## Configuração

### Pré-requisitos

- .NET 8 SDK ou superior
- Ferramenta de gerenciamento de pacotes NuGet

### Instalação

1. Clone o repositório:
   ```sh
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
