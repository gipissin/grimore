<div align="center">

```
☽ ✧ · · · ✧ ☾
G R I M O R E
☽ ✧ · · · ✧ ☾
```

**Sistema de Gerenciamento de Biblioteca**

*"Todo grimório guarda segredos entre suas páginas.*
*Este guarda livros, usuários e empréstimos —*
*sob a guarda silenciosa de um gato bibliotecário que nunca dorme."*

---

![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat-square&logo=microsoftsqlserver&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white)
![Windows Forms](https://img.shields.io/badge/WinForms-0078D4?style=flat-square&logo=windows&logoColor=white)

</div>

---

## ✦ Sobre o Grimore

O **Grimore** é uma aplicação desktop para gerenciamento de acervo bibliotecário, desenvolvida em VB.NET com Windows Forms e SQL Server. Pensada para o controle completo de livros, usuários e empréstimos em uma interface limpa e funcional.

Desenvolvido como projeto acadêmico do curso de Análise e Desenvolvimento de Sistemas da FATEC São Caetano do Sul.

---

## ✦ Funcionalidades

| Módulo | Descrição |
|---|---|
| Acervo | Cadastro, busca e listagem de livros com filtros por categoria e disponibilidade |
| Usuários | Gerenciamento de alunos e professores com controle de acesso por perfil |
| Empréstimos | Registro de retiradas e devoluções com histórico e alertas de prazo |
| Autenticação | Login com validação, troca de senha e sessões por nível de permissão |

---

## ✦ Stack

```
Linguagem     →  VB.NET (.NET Framework)
Interface     →  Windows Forms (WinForms)
Banco         →  Microsoft SQL Server
Acesso        →  ADO.NET (SqlClient / ADODB)
IDE           →  Visual Studio 2022
Versionamento →  Git + GitHub
```

---

## ✦ Primeiros passos

**Pré-requisitos:**
- Visual Studio 2022 (com suporte a VB.NET)
- SQL Server (local ou instância configurada)

**Instalação:**

```bash
# 1. Clone o repositório
git clone https://github.com/gipissin/grimore.git

# 2. Abra Grimore_Library.sln no Visual Studio

# 3. Configure a connection string em App.config
# connectionString="Data Source=SEU_SERVIDOR;Initial Catalog=grimoire_db;..."

# 4. Execute o script de criação do banco
# /Database/schema.sql

# 5. Build & Run (F5)
```

---

## ✦ Estrutura do projeto

```
Grimore_Library/
├── Database/
│   └── schema.sql              → script consolidado de criação das tabelas
├── frm_acervo.vb               → gerenciamento do acervo de livros
├── frm_admin.vb                → painel administrativo do sistema
├── frm_cadclientes.vb          → cadastro de clientes/leitores
├── frm_cadusuario.vb           → cadastro de usuários do sistema
├── frm_emprestimo.vb           → registro e controle de retiradas
├── frm_menu.vb                 → menu principal da aplicação
├── login_principal.vb          → tela de autenticação
├── modulo_grimore.vb           → módulo de variáveis e conexões globais
└── README.md
```

---

## ✦ Guardiãs do Grimório

<div align="center">

| | | |
|:---:|:---:|:---:|
| **Giovanna Vinturi** | **Aline Michelle** | **Julia Simões** |
| [@gipissin](https://github.com/gipissin) | [@minhas-estrelas](https://github.com/minhas-estrelas) | [@Jublii](https://github.com/Jublii) |

</div>

---

<div align="center">

*Projeto acadêmico — Análise e Desenvolvimento de Sistemas (FATEC-SCS)*

`feito com código, café e um gato que nunca sai do teclado`

</div>
