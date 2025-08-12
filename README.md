# Sistema de Estacionamento - DIO .NET

Projeto desenvolvido como parte do Bootcamp Avanade - Back-end com .NET e IA, implementando um sistema completo de gerenciamento de estacionamento com diferentes tipos de vagas e modalidades de preço.

## 💡 Visão Geral

O sistema foi desenvolvido para atender as necessidades de um estacionamento comercial moderno, oferecendo funcionalidades avançadas de gestão de vagas e precificação flexível.

## 📋 Funcionalidadestema de Estacionamento - DIO .NET

Projeto desenvolvido como parte do Bootcamp Avanade - Back-end com .NET e IA, implementando um sistema completo de gerenciamento de estacionamento com diferentes tipos de vagas e modalidades de preço.

## � Funcionalidades Implementadas

- **Sistema de Vagas**
  - Vagas Rotativas (curta permanência)
  - Vagas Reservadas (períodos fixos)

- **Precificação Flexível**
  - Preços por hora: R$ 15,00/hora (até 5 horas)
  - Turno Manhã: R$ 50,00
  - Turno Tarde: R$ 70,00
  - Turno Noite: R$ 100,00
  - Diária completa: R$ 200,00

- **Gestão de Veículos**
  - Cadastro completo (placa, modelo, marca, cor, tipo)
  - Controle de entrada e saída
  - Cálculo automático de valores
  - Registro de permanência
  
## ⚙️ Planejamento do Projeto
Este é um projeto de um sistema de gerenciamento de estacionamento desenvolvido em C# (.NET 6.0), que simula o funcionamento de um estacionamento comercial com diferentes tipos de vagas e modalidades de preços.

Principais funcionalidades implementadas:

Gerenciamento de Veículos:

Cadastro completo de veículos com informações como placa, modelo, marca, cor e tipo
Listagem de todos os veículos estacionados
Remoção de veículos com cálculo automático do valor a ser pago
Sistema de Vagas:

Dois tipos de vagas disponíveis:
Vagas Rotativas: ideal para curta permanência
Vagas Reservadas: para clientes que precisam de períodos fixos
Sistema de Preços Flexível:

Preços por hora: R$ 15,00/hora (até 5 horas)
Preços por turno:
Turno Manhã: R$ 50,00
Turno Tarde: R$ 70,00
Turno Noite: R$ 100,00
Diária completa: R$ 200,00
Controle de Permanência:

Registro do horário de entrada
Cálculo automático de valores baseado no período escolhido
Diferentes opções de períodos de permanência
Interface Amigável:

Menus interativos e intuitivos
Feedback visual com formatação clara
Mensagens de confirmação e status
Aplicabilidade: Este sistema pode ser utilizado em diversos cenários, como:

Estacionamentos comerciais
Shoppings centers
Prédios comerciais
Eventos temporários
Aeroportos e terminais
O projeto foi estruturado usando boas práticas de programação:

Orientação a Objetos com classes bem definidas (Cliente, Veículo, Estacionamento)
Encapsulamento adequado dos dados
Validações de entrada
Código limpo e organizado
Interface de usuário consistente
O sistema é especialmente útil para estabelecimentos que precisam:

Gerenciar diferentes tipos de vagas
Oferecer opções flexíveis de permanência
Ter controle preciso sobre entrada e saída de veículos
Calcular valores automaticamente
Manter registro dos clientes e seus veículos
É um projeto prático que demonstra conceitos importantes de programação e pode ser expandido com novas funcionalidades conforme necessário.
  
## � Demonstração do Sistema

### 1. Menu Principal
![Menu Principal](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi1.png)
*Tela inicial do sistema com as opções disponíveis*

### 2. Cadastro de Veículo
![Adicionar Veículo](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi2.png)
*Interface de cadastro com informações do veículo*

### 3. Seleção do Tipo de Vaga
![Tipo de Vaga](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi3.png)
*Escolha entre vaga rotativa ou reservada*

### 4. Configuração do Período
![Configurar Período](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi4.png)
*Definição do período e visualização dos preços*

### 5. Confirmação do Cadastro
![Sucesso no Cadastro](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi5.png)
*Confirmação do registro com detalhes da vaga*

### 6. Listagem de Veículos
![Lista de Veículos](images/screenshots/6-listar-veiculos.png)
*Visualização de todos os veículos estacionados*

### 7. Remoção e Pagamento
![Remover Veículo](images/screenshots/7-remover-veiculo.png)
*Processo de saída e cálculo do valor a ser pago*

## 🛠️ Tecnologias

- C# (.NET 6.0)
- Orientação a Objetos
- Visual Studio Code
- Git/GitHub
  
## ⚙️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd desafio-trilha-dotnet-fundamentos
   ```

3. Execute o projeto:
   ```bash
   dotnet run
   ```


#### A classe contém três variáveis, sendo:

- precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.
- precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.
- veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

#### A classe contém três métodos, sendo:

- AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.
- RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.
- ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

#### Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar

#### Solução
O código foi fornecido pela metade, e a função do desenvolvedor era dar continuidade obedecendo as regras descritas acima, para que no final, se tenha um programa funcional.

#### Especificações de conteúdo:
- Indique um nome para seu negócio.
- Sua composição de estacionamento (cadastrar, remover, listar e encerrar).
- O programa de conter classe e métodos.
- A saída deve exibir a placa do veículo removido e o valor a ser pago.

#### Especificações técnicas:
- Todos os dados são capturados pelo console (entrada do usuário).
- Exibir mensagens apropriadas a cada situação (você tem que interagir com o usuário).
- O usuário tem a opção de não escolher nada e encerrrar o sistema.
- Utilizar decimais e conversores nos itens.
- Utilizar estruturas como: `if / else`, `for`, `foreach` e `switch`

### ▶️ Instruções de Uso

1. Clone ou baixe este repositório para a sua máquina local.

2. Certifique-se de ter o [Node.js](https://nodejs.org/en/download/current) e [.NET 8.0](https://dotnet.microsoft.com/pt-br/download) instalado em sua máquina.

3. Abra o terminal e navegue até o diretório raiz do projeto.

4. Para executar, utilize o comando:
```
dotnet run
```

## �🏻‍💻 Autor

Desenvolvido por [Italo Rocha](https://github.com/ItaloRochaj) como parte do Bootcamp Avanade - Back-end com .NET e IA.

## 📄 Licença

Este projeto foi desenvolvido como parte do Bootcamp Avanade - Back-end com .NET e IA e é distribuído sob a licença MIT.

---
<div align="center">Desenvolvido com ❤️ por <a href="https://github.com/ItaloRochaj">Italo Rocha</a></div>
