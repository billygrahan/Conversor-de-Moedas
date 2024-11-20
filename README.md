# Conversor de Moedas

Uma aplicação console para conversão de moedas utilizando a API da [ExchangeRate-API](https://www.exchangerate-api.com). A aplicação permite realizar consultas em tempo real da taxa de câmbio entre duas moedas e converter um valor de uma moeda para outra.

---

## Funcionalidades

- Conversão de valores entre diferentes moedas.
- Validação de entradas como:
  - Código de moedas (ISO 4217) - [Codigos](https://www.exchangerate-api.com).
  - Valores numéricos positivos.
  - Verificação de moedas distintas.
- Tratamento de erros detalhado, como:
  - Problemas de conexão.
  - Limitações da chave de API.
  - Formato incorreto de entrada.

---

## Requisitos

- .NET 6.0 ou superior.
- Chave de API válida da [ExchangeRate-API](https://www.exchangerate-api.com).

---

## Como configurar o projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/conversor-de-moedas.git
   cd conversor-de-moedas
   ```

2. **Obtenha uma chave de API**
   - Cadastre-se no [ExchangeRate-API](https://www.exchangerate-api.com).
   - Copie sua chave de API.

3. **Adicione sua chave ao projeto**
   - Crie um arquivo chamado `YOUR-API-KEY.txt` no diretório `Utils`.
   - Cole sua chave no arquivo.

4. **Compile e execute o projeto**
   ```bash
   dotnet run --project Conversor-de-Moedas
   ```

---

## Como usar a aplicação

1. **Iniciar a aplicação**
   - Execute o projeto, e o sistema pedirá os seguintes inputs:
     - **Moeda Origem**: Código da moeda de origem (ex.: `USD`).
     - **Moeda Destino**: Código da moeda para conversão (ex.: `BRL`).
     - **Valor**: O valor numérico a ser convertido (ex.: `100`).

2. **Saída esperada**
   - A aplicação exibirá o valor convertido, a moeda de origem e destino, e a taxa de câmbio utilizada.
   - Exemplo:
     ```
     Moeda Origem: USD
     Moeda Destino: BRL
     Valor: 100

     USD 100.00 => BRL 507.50
     Taxa: 5.075000
     ```

3. **Erros**
   - Se ocorrer algum erro, o sistema exibirá uma mensagem detalhada (ex.: chave inválida, moedas iguais, etc.).

---

## Estrutura do Projeto

- **Models**
  - `Sistema`: Classe principal que gerencia a lógica do programa.
  - `API_Response`: Modelo para armazenar as respostas da API.

- **UI**
  - `Interface`: Gerencia a interação com o usuário.

- **Utils**
  - `Erros`: Define mensagens para diferentes tipos de erro.

- **Validations**
  - `ValidaConsultas`: Valida as Diferentes respostas que a requisição da API pode fornecer.
  - `ValidaEntradas`: Valida entradas fornecidas pelo usuário.

---

## Tratamento de erros

- **Mensagens de erro detalhadas**:
  - Exemplo: `Sua chave de API não é válida.`
- **Erros comuns tratados**:
  - Problemas de conexão.
  - Formato incorreto das moedas.
  - Limite de requisições da chave de API.

---

## Tecnologias Utilizadas

- .NET 6.0
- [Newtonsoft.Json](https://www.newtonsoft.com/json) para manipulação de JSON.
- [ExchangeRate-API](https://www.exchangerate-api.com) para taxa de câmbio.

---

## Melhorias Futuras

- Interface gráfica (GUI) para interação.
- Suporte a múltiplas conversões simultâneas.
- Opções para salvar históricos de conversões.

---

O código é livre Contribuições e sugestões são bem-vindas!??