# StudyingDDD

Esse repositório começou com o intuito de colocar em prática o que foi aprendido no curso CSharp Parte Sete da Alura, porém acabou virando um estudando sobre DDD.

Pude aprender como funciona o framework de injeção de dependência do .NET e também o framework de hosting para aplicações.

Implementei o padrão de camada de persistência de infraestrutura utiliza EF Core Code First e In Memory.

Pude também implementar o padrão de N camadas, para deixar a aplicação mais modularizada e fácil de manutenção.

Ainda preciso estudar bastante sobre clean architecture, testes unitários e boas práticas para aumentar a qualidade do código escrito

## Project structure (src directory)

**Application** --Applcation layer

- Program.cs

**Services** --Business Logic

- Interfaces
  - IAudioAlertsService
  - IAudiosService
- Services
  - AudioAlertsService
  - AudiosService

**Infra** --Data Storage

- Interfaces
  - Base
    - IBasicRepository
  - Files
    - IAudioRepository
    - IAudioAlertsRepository
- Repositories
  - Base
    - BasicRepository
  - Files
    - AudioRepository
    - AudioAlertsRepository

**Entities** --Model

- Files
  - Audio
  - AudioAlerts
