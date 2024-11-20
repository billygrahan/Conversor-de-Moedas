# Conversor de Moedas

Uma aplica��o console para convers�o de moedas utilizando a API da [ExchangeRate-API](https://www.exchangerate-api.com). A aplica��o permite realizar consultas em tempo real da taxa de c�mbio entre duas moedas e converter um valor de uma moeda para outra.

---

## Funcionalidades

- Convers�o de valores entre diferentes moedas.
- Valida��o de entradas como:
  - C�digo de moedas (ISO 4217) - [Codigos](https://www.exchangerate-api.com).
  - Valores num�ricos positivos.
  - Verifica��o de moedas distintas.
- Tratamento de erros detalhado, como:
  - Problemas de conex�o.
  - Limita��es da chave de API.
  - Formato incorreto de entrada.

---

## Requisitos

- .NET 6.0 ou superior.
- Chave de API v�lida da [ExchangeRate-API](https://www.exchangerate-api.com).

---

## Como configurar o projeto

1. **Clone o reposit�rio**
   ```bash
   git clone https://github.com/seu-usuario/conversor-de-moedas.git
   cd conversor-de-moedas
   ```

2. **Obtenha uma chave de API**
   - Cadastre-se no [ExchangeRate-API](https://www.exchangerate-api.com).
   - Copie sua chave de API.

3. **Adicione sua chave ao projeto**
   - Crie um arquivo chamado `YOUR-API-KEY.txt` no diret�rio `Utils`.
   - Cole sua chave no arquivo.

4. **Compile e execute o projeto**
   ```bash
   dotnet run --project Conversor-de-Moedas
   ```

---

## Como usar a aplica��o

1. **Iniciar a aplica��o**
   - Execute o projeto, e o sistema pedir� os seguintes inputs:
     - **Moeda Origem**: C�digo da moeda de origem (ex.: `USD`).
     - **Moeda Destino**: C�digo da moeda para convers�o (ex.: `BRL`).
     - **Valor**: O valor num�rico a ser convertido (ex.: `100`).

2. **Sa�da esperada**
   - A aplica��o exibir� o valor convertido, a moeda de origem e destino, e a taxa de c�mbio utilizada.
   - Exemplo:
     ```
     Moeda Origem: USD
     Moeda Destino: BRL
     Valor: 100

     USD 100.00 => BRL 507.50
     Taxa: 5.075000
     ```

3. **Erros**
   - Se ocorrer algum erro, o sistema exibir� uma mensagem detalhada (ex.: chave inv�lida, moedas iguais, etc.).

---

## Estrutura do Projeto

- **Models**
  - `Sistema`: Classe principal que gerencia a l�gica do programa.
  - `API_Response`: Modelo para armazenar as respostas da API.

- **UI**
  - `Interface`: Gerencia a intera��o com o usu�rio.

- **Utils**
  - `Erros`: Define mensagens para diferentes tipos de erro.

- **Validations**
  - `ValidaConsultas`: Valida as Diferentes respostas que a requisi��o da API pode fornecer.
  - `ValidaEntradas`: Valida entradas fornecidas pelo usu�rio.

---

## Tratamento de erros

- **Mensagens de erro detalhadas**:
  - Exemplo: `Sua chave de API n�o � v�lida.`
- **Erros comuns tratados**:
  - Problemas de conex�o.
  - Formato incorreto das moedas.
  - Limite de requisi��es da chave de API.

---

## Tecnologias Utilizadas

- .NET 6.0
- [Newtonsoft.Json](https://www.newtonsoft.com/json) para manipula��o de JSON.
- [ExchangeRate-API](https://www.exchangerate-api.com) para taxa de c�mbio.

---

## Melhorias Futuras

- Interface gr�fica (GUI) para intera��o.
- Suporte a m�ltiplas convers�es simult�neas.
- Op��es para salvar hist�ricos de convers�es.

---

O c�digo � livre Contribui��es e sugest�es s�o bem-vindas!??