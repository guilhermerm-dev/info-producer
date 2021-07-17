Info Producer
=====================
Este projeto tem como intuito realizar a prova de conceito do modelo de aplicação utilizado para realizar publicaçãoes em uma fila de mensageiria implementada com RabbitMq. 

## Dê uma estrela :star:
Se você gostou deste projeto ou se te ajudou, por favor, dê uma estrela ;)

## Como usar:
- Você vai precisar da versão mais recente do Visual Studio 2019 ou se preferir, pode ser utilizado o Visual Studio Code.
- Além das IDE's, será preciso instalar o SDK do .NET mais atualizado.
- ***Verifique se você tem instalado a mesma versão do runtime (SDK) da aplicação***
- Você pode realizar o download das ultimas versões de ferramentas e SDK através do site https://dot.net/core.

Comandos .NET CLI que podem ser executados no diretório do projeto:
- **Limpar projetos**: ```dotnet clean```
- **Restaurar pacotes Nuget**: ```dotnet restore```
- **Buildar projetos**: ```dotnet build```
- **Executar Testes Unitarios e de Integração**: ```dotnet test```
- **Executar Projeto**: ```dotnet run```

Você também pode executar este projeto em qualquer SO, sendo ele Windows, Linux ou MacOs.

Para saber mais sobre como realizar o setup do ambiente .NET visite [Microsoft .NET Download Guide](https://www.microsoft.com/net/download) 

## Tecnologias implementadas:
- ASP.NET 5.0 (with .NET Core 5.0)
- RabbitMqClient [RabbitMqClient](https://www.nuget.org/packages/RabbitMQ.Client/)