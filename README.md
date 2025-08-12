# Sistema de Estacionamento - DIO .NET

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
  
## 🛠️ Tecnologias Utilizadas

- **Linguagens e Frameworks:**
  - C# (.NET 6.0)
  - Visual Studio Code
  - Git/GitHub
  
## 🗒️ Requisitos do Projeto
> Projeto - Sistema de Estacionamento
- Desafio de projeto: Para este desafio, foi preciso utilizar os conhecimentos adquiridos no módulo de fundamentos, do Bootcamp na Avanade - Back-end com .NET e IA
- Contexto: Na proposta desafio o desenvoledor foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.
- Proposta: Foi preciso construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:


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

### 🔗 Créditos
Este projeto foi desenvolvido como parte de avaliação de desafio da Avanade - Back-end com .NET e IA, para avaliar o ensinado na bootcamp de fundamentos da linguagem de programação `C#`.

*Nota: Este projeto é apenas para fins educacionais e não possui nenhuma afiliação oficial com a franquia DIO ou Avanade ou suas empresas associadas.*

## Autoria:
<table style="border: 0;">
  <tr>
    <td align="left">
      <a href="https://github.com/italorochaj">
        <span><b>Italo Rocha</b></span>
      </a>
      <br>
      <span>Assoc, Full-Stack Development</span>
    </td>
  </tr>
</table>

##
<div align="center">Feito por <a href="https://github.com/italorochaj">@devrhakramer</a>.</div>
