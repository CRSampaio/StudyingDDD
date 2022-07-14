# C Sharp Parte Sete

Aprendi a como nomear os argumentos ao instânciar uma classe ou invocar um metódo.

Essa abordagem normalmente é usada em parâmetros que contém um valor padrão.

Aprendi também a como criar metódos com indexadores.

**Keyword** params, utilizada antes de um parâmetro de metódo ou construtor, serve para indicar que podem ser passados N váriaveis daquele tipo, que serão convertidas para um array

Ao colocar o **<>** na frente do nome da classe, estamos declarando que a classe é de um tipo genérico que será definida no momento em que será instânciada

Váriaveis do tipo valor e tipo referência

Application --View and Controller

Services --Business Logic
    - Interfaces
        - IProcessAudioService
    - Services
        - ProcessAudioService

Infra --Data Storage
    - Interfaces
        - IBasicRepository
        - IAudioRepository
        - IAudioAlertsRepository
    - Repositories
        - BasicRepository
        - AudioRepository
        - AudioAlertsRepository

Entities --Model
    - Audio
    - AudioAlerts
