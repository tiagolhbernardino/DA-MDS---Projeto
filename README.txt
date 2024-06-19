# Icantina - Projeto da UC de Desenvolvimento de aplicações

O iCantina é um sistema de gestão desenvolvido para otimizar as operações diárias de uma cantina. Este software foi criado para permitir que os funcionários da cantina gerenciem menus semanais, controlem reservas de refeições, carreguem as suas contas e processem a faturação de maneira eficiente. A aplicação fornece uma interface intuitiva e robusta para a gestão de pratos, extras, menus e multas, além de possibilitar a criação e manutenção de registros detalhados de clientes e funcionários. A integração a base de dados, utilizando o Entity Framework, garante a integridade e a persistência dos dados, assegurando um funcionamento fluido. Este ficheiro era ter as diretrizes para a instalar, configurar e utilizar o sistema além de justificar algumas escolhas técnicas e funcionais feitas durante o desenvolvimento do projeto.

---

# 🚀 Pré-requisitos:



## 🚀 A instalar: 

1) Visual Studio 2022 ou superior
2) .NET Framework 4.8 ou superior
3) Entity Framework 6


## 🚀 Configuração da Base de Dados:

1) Abrir a "solution" iCantina
2) Abrir a consola (Tools > Nugget Package Manager > Package Manager Console)
3) Executar o comado <Update-Database> para fazer as migraçoes


## 🚀 Executar a Aplicação:

1) Depois da configuração à base de dados executar a aplicação a partir do Visual Studio.
2) Para o primeiro "login" deve ser utilizado as credenciais username: admin/ password: admin (e só depois será possivel criar novas contas)

---

# 📋 Utilização:
## O iCantina é composto por diversos formulários para a gestão completa da cantina:

## 📋 Formulário Principal:
Acesso às funcionalidades da aplicação, visualização dos menus semanais e navegação entre semanas.

## 📋Formulário de Reservas:
Efetuar reservas, marcar reservas como efetuadas, e geração de ficheiros de texto e PDF para as reservas e faturas.

## 📋Formulário de Pratos:
Visualização, criação, atualização e eliminação de pratos.

## 📋Formulário de Extras:
Visualização, criação, atualização e eliminação de extras.

## 📋Formulário de Multas:
Visualização, criação, atualização e eliminação de multas.

## 📋Formulário de Gestão de Clientes:
Visualização, criação, atualização e eliminação de clientes.

## 📋Formulário de Menu:
Criação e gestão de menus diários, incluindo a adição e remoção de pratos e extras.

## 📋Formulário de Funcionários:
Visualização, criação, atualização e eliminação de funcionários.

---

# 🔧Funcionalidades Adicionais
## Foram implementadas as seguintes funcionalidades extra:

1) Envio por email da fatura em PDF para o cliente, com assunto e corpo personalizado.
2) Lista de pratos e extras mais reservados.
3) Tipos de pratos mais reservados por dia da semana.
4) Visualização mensal dos menus, permitindo a navegação entre meses.

---

## ⚙️ Executando os testes

1) Teste de criação, ediçao, verificaçao e remoção dos funcionários.
2) Teste de criação, edição, verificaçao e remoçao de pratos par o menu
3)
4)
5)
6)
7)
8)
9)
12)
13)
14)
15)




---
## 🛠️ Feito Por
Dinis Ruivo
Luisa Pacheco
Tiago Bernadino		
Tiago Estrela


