# 🚗 Sistema de Estacionamento - Trilha .NET DIO

![.NET](https://img.shields.io/badge/.NET-6.0-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Console](https://img.shields.io/badge/Console-Application-000000?style=for-the-badge&logo=windows-terminal&logoColor=white)
![OOP](https://img.shields.io/badge/OOP-Oriented%20Programming-FF6B6B?style=for-the-badge&logo=code&logoColor=white)

## 🎯 Visão Geral

Este projeto é um **Sistema Completo de Gerenciamento de Estacionamento** desenvolvido como parte do **Bootcamp Avanade - Back-end com .NET e IA**. A aplicação implementa um sistema robusto de controle de vagas com diferentes tipos de estacionamento, precificação flexível e interface interativa via console.

## ⚡ Funcionalidades Implementadas

### 🚗 Gestão Completa de Veículos
- ✅ **Cadastro de veículos** - Registro completo com placa, modelo, marca, cor e tipo
- ✅ **Listagem de veículos** - Visualização de todos os veículos estacionados
- ✅ **Remoção de veículos** - Processo de saída com cálculo automático de valores
- ✅ **Validação de placas** - Verificação de veículos já estacionados

### 🏢 Sistema de Vagas Avançado
- ✅ **Vagas Rotativas** - Para permanência por hora ou turnos
- ✅ **Vagas Reservadas** - Para períodos fixos com valores diferenciados
- ✅ **Controle de ocupação** - Rastreamento de entrada e tipo de vaga
- ✅ **Histórico de permanência** - Registro de data/hora de entrada

### 💰 Precificação Inteligente
- ✅ **Preços por hora** - R$ 15,00/hora (até 5 horas)
- ✅ **Turno Manhã** - R$ 50,00 (período matutino)
- ✅ **Turno Tarde** - R$ 70,00 (período vespertino)
- ✅ **Turno Noite** - R$ 100,00 (período noturno)
- ✅ **Diária completa** - R$ 200,00 (24 horas)

### 🎨 Interface Interativa
- ✅ **Menus formatados** - Interface visual clara e organizada
- ✅ **Validações de entrada** - Verificação de dados do usuário
- ✅ **Mensagens informativas** - Feedback visual para todas as ações
- ✅ **Navegação intuitiva** - Fluxo de uso simplificado

## 🏗️ Estrutura do Projeto

```
desafio-trilha-dotnet-fundamentos/
├── 📁 DesafioFundamentos/
│   ├── 📁 Models/
│   │   ├── Estacionamento.cs          # Classe principal do sistema
│   │   ├── Cliente.cs                 # Modelo de dados do cliente
│   │   └── Veiculo.cs                 # Modelo de dados do veículo
│   ├── 📁 bin/Debug/net6.0/          # Arquivos compilados
│   ├── 📁 obj/                        # Arquivos de build
│   ├── Program.cs                     # Ponto de entrada da aplicação
│   └── DesafioFundamentos.csproj      # Arquivo de projeto
├── 📁 images/
│   └── 📁 screenshots/                # Capturas de tela do sistema
├── desafio-trilha-dotnet-fundamentos.sln  # Solution do projeto
├── diagrama_classe_estacionamento.png     # Diagrama de classes
└── README.md                              # Documentação do projeto
```

## 🎯 Regras de Negócio

### 🚗 Modelo de Veículo
- **Placa**: Identificador único do veículo (obrigatório)
- **Modelo**: Modelo do veículo (obrigatório)
- **Marca**: Fabricante do veículo (obrigatório)
- **Cor**: Cor do veículo (obrigatório)
- **Tipo**: Categoria (Carro/Moto/Outro) (obrigatório)

### 👤 Modelo de Cliente
- **Nome**: Nome do proprietário do veículo
- **Documento**: Documento de identificação
- **Veículo**: Veículo associado ao cliente

### 🏢 Sistema de Vagas
- **Vaga Rotativa**: Ideal para curta permanência (hora/turno)
- **Vaga Reservada**: Para períodos específicos (turno/diária)
- **Controle de entrada**: Registro automático de data/hora
- **Cálculo automático**: Valores baseados no período escolhido

### ⚖️ Validações Implementadas
1. **Placa única**: Não permite veículos duplicados
2. **Dados obrigatórios**: Valida preenchimento de campos essenciais
3. **Período válido**: Verifica seleção de período apropriado
4. **Tipo de vaga**: Valida escolha entre rotativa/reservada
5. **Valores numéricos**: Tratamento seguro de entrada de horas

## 🛠️ Boas Práticas Implementadas

### 🏛️ Arquitetura
- ✅ **Orientação a Objetos** - Classes bem definidas e encapsuladas
- ✅ **Separação de Responsabilidades** - Models organizados por domínio
- ✅ **Encapsulamento** - Dados protegidos com métodos de acesso
- ✅ **Reutilização de código** - Métodos modulares e reutilizáveis

### 📝 Código Limpo
- ✅ **Nomenclatura clara** - Variáveis e métodos com nomes descritivos
- ✅ **Comentários úteis** - Documentação onde necessário
- ✅ **Estrutura organizada** - Código bem formatado e indentado
- ✅ **Tratamento de erros** - Validações e mensagens apropriadas

### 🎨 Interface do Usuário
- ✅ **Menus visuais** - Formatação com bordas e separadores
- ✅ **Feedback visual** - Mensagens de sucesso e erro
- ✅ **Navegação intuitiva** - Fluxo lógico de operações
- ✅ **Limpeza de tela** - Interface sempre organizada

## 🚀 Tecnologias Utilizadas

### 🎨 Framework e Runtime
- **.NET 6.0** - Framework principal
- **C#** - Linguagem de programação
- **Console Application** - Tipo de aplicação

### 🗄️ Estruturas de Dados
- **List<T>** - Gerenciamento de coleções
- **Dictionary<TKey, TValue>** - Mapeamento chave-valor para vagas
- **DateTime** - Controle de data e hora
- **Decimal** - Precisão monetária

### 🛠️ Conceitos Aplicados
- **Orientação a Objetos** - Classes, propriedades, métodos
- **Encapsulamento** - Modificadores de acesso
- **Coleções** - Listas e dicionários
- **Estruturas de Controle** - if/else, switch, foreach
- **Tratamento de Exceções** - try/catch para entradas inválidas

### 🛠️ Ferramentas de Desenvolvimento
- **Visual Studio Code** - IDE
- **Git** - Controle de versão
- **GitHub** - Repositório remoto

## 🖥️ Demonstração do Sistema

### 📸 Fluxo Completo de Operações

O sistema possui uma interface interativa completa acessível via console:

![Menu Principal](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi2.png)
*Tela inicial com todas as opções disponíveis*

![Cadastro de Veículo](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi3.png)
*Interface de cadastro com validação de dados*

![Seleção de Tipo de Vaga](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi4.png)
*Escolha entre vagas rotativas e reservadas*

![Configuração de Período](https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos/blob/v1.0/DesafioFundamentos/images/Assets/termi5.png)
*Definição de período com exibição de preços*


### 🔗 Operações Disponíveis

| Opção | Funcionalidade | Descrição |
|-------|----------------|-----------|
| `1` | Cadastrar veículo | Registro completo de novo veículo |
| `2` | Remover veículo | Saída com cálculo de pagamento |
| `3` | Listar veículos | Visualização de todos estacionados |
| `4` | Encerrar | Finalização do sistema |

### 💰 Estrutura de Preços

```
Preços por Hora (Vagas Rotativas):
- 1 hora: R$ 15,00
- 2 horas: R$ 30,00
- 3 horas: R$ 45,00
- 4 horas: R$ 60,00
- 5 horas: R$ 75,00

Preços por Turno (Ambas as vagas):
- Turno Manhã: R$ 50,00
- Turno Tarde: R$ 70,00
- Turno Noite: R$ 100,00
- Diária Completa: R$ 200,00
```

## 🚀 Como Executar

### 📋 Pré-requisitos
- .NET 6.0 SDK instalado
- Visual Studio Code ou Visual Studio
- Git (opcional)

### 🔧 Passos para Execução

1. **Clone o repositório**
```bash
git clone https://github.com/ItaloRochaj/desafio-trilha-dotnet-fundamentos.git
cd desafio-trilha-dotnet-fundamentos
```

2. **Navegue até o projeto**
```bash
cd DesafioFundamentos
```

3. **Restaure as dependências**
```bash
dotnet restore
```

4. **Execute a aplicação**
```bash
dotnet run
```

### ⚡ Execução Rápida
```bash
# Para desenvolvimento rápido
dotnet run --project DesafioFundamentos.csproj
```

## 🎯 Principais Características

### 🔥 Performance
- ✅ **Estruturas otimizadas** - Uso eficiente de coleções
- ✅ **Busca rápida** - Dictionary para controle de vagas
- ✅ **Memória eficiente** - Gerenciamento adequado de objetos

### 🛡️ Robustez
- ✅ **Validação de entrada** - Verificação de dados do usuário
- ✅ **Tratamento de erros** - Mensagens claras para situações inválidas
- ✅ **Controle de duplicatas** - Prevenção de placas repetidas

### 🎨 Usabilidade
- ✅ **Interface intuitiva** - Menus claros e organizados
- ✅ **Feedback imediato** - Confirmações e alertas visuais
- ✅ **Navegação simples** - Fluxo lógico de operações

### 🔧 Manutenibilidade
- ✅ **Código organizado** - Classes bem estruturadas
- ✅ **Métodos modulares** - Funções com responsabilidades específicas
- ✅ **Fácil extensão** - Arquitetura preparada para novas funcionalidades

## 📈 Melhorias Futuras

- 🔄 Persistência em banco de dados
- 🔐 Sistema de autenticação para operadores
- 📊 Relatórios de ocupação e faturamento
- 🧪 Testes unitários e de integração
- 🌐 Interface web ou API REST
- 📱 Aplicativo mobile para gestão
- 💳 Integração com sistemas de pagamento
- 📄 Geração de recibos e comprovantes

## 👨🏻‍💻 Autor

**Ítalo Rocha**
- 🌐 GitHub: [@ItaloRochaj](https://github.com/ItaloRochaj)
- 💼 LinkedIn: [https://www.linkedin.com/in/italorochaj/]

---

## 📄 Licença

Este projeto foi desenvolvido como parte do **Bootcamp Avanade - Back-end com .NET e IA**.
