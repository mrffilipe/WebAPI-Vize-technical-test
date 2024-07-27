# WebAPI Vize Technical Test

## Descrição

Esta aplicação é uma API de Produtos desenvolvida como parte de um teste técnico. A API permite operações CRUD (Create, Read, Update, Delete) em produtos e fornece um dashboard com a quantidade e o preço unitário médio dos produtos, segregados por tipo.

## Pré-requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) (versão 8)
- [Docker](https://www.docker.com/get-started) (opcional, para subir o banco de dados PostgreSQL)
- [PostgreSQL](https://www.postgresql.org/download/) (caso não utilize Docker)

## Configuração e Execução

### 1. Subir o Container Docker para o PostgreSQL (Opcional)

Um arquivo `docker-compose.yml` já existe no diretório raiz da aplicação. Esse arquivo está configurado para subir um container Docker com PostgreSQL usando as seguintes configurações: usuário `admin`, senha `admin`, nome do banco `webapi_vize_technical_test` e porta `5432`.

Execute o comando para subir o container:
```bash
docker-compose up -d
```

Alternativamente, você pode usar um banco de dados PostgreSQL já operacional na máquina, sem necessidade de subir um container Docker.

### 2. Ajustar a Connection String

Ajuste a string de conexão (DefaultConnection) dentro do arquivo `appsettings.json` com os dados do banco de dados que está operacional:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=webapi_vize_technical_test;Username=admin;Password=admin"
  }
}
```

### 3. Restaurar os Pacotes da Aplicação

Certifique-se de que a aplicação restaurou todos os pacotes necessários. No diretório da aplicação, execute:
```bash
dotnet restore
```

### 4. Aplicar Migrações

Certifique-se de que o diretório `Migrations` existe dentro do projeto. Se o diretório não existir, crie uma nova migração:
```bash
Add-Migration <nome_da_migration>
```

Em seguida, aplique as migrações para atualizar o banco de dados:
```bash
Update-Database
```

### 5. Executar a Aplicação

Agora você pode executar a aplicação:
```bash
dotnet run
```

A API estará disponível em `https://localhost:5000` ou `http://localhost:5001`.

## Testes

Para testar a API, você pode usar ferramentas como Postman ou Insomnia. Certifique-se de adicionar o cabeçalho de autorização para acessar os endpoints protegidos. Forneça o username `admin`, senha `password`e tipo de autenticação `basic`.

## Endpoints da API

- `GET /api/product/{id}`: Obtém um produto por ID.
- `GET /api/product`: Obtém todos os produtos.
- `POST /api/product`: Adiciona um novo produto.
- `PUT /api/product/{id}`: Atualiza um produto existente.
- `DELETE /api/product/{id}`: Deleta um produto por ID.
- `GET /api/dashboard/get-dashboard`: Obtém os dados do dashboard.

## Melhorias Futuras

Para melhorar ainda mais a qualidade do software, a implementação de testes unitários é recomendada. Testes unitários garantem que as funcionalidades individuais da aplicação estão funcionando conforme esperado, facilitam a manutenção e ajudam a prevenir regressões. Ferramentas como xUnit ou NUnit podem ser utilizadas para criar testes unitários em projetos .NET.