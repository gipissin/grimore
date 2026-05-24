<div align="center">

# 🌙 GRIMOIRE 🐱

*Plataforma de Gestão para Bibliotecas de Acervo Nacional*

![VB.Net](https://img.shields.io/badge/VB.Net-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-003B57?style=for-the-badge&logo=databricks&logoColor=white)

</div>

---

## 📖 Sobre o Projeto

O **Grimoire** é uma plataforma de gestão desenvolvida para bibliotecas especializadas em acervo nacional. O sistema tem como foco principal o bibliotecário, oferecendo controle total sobre o ciclo de vida do livro — desde o cadastro até o empréstimo — além do gerenciamento completo da base de clientes.

O objetivo é reduzir perdas de acervo e otimizar o tempo de consulta de disponibilidade.

---

## ✨ Funcionalidades

- 📋 **Cadastro de Livros** — Registro completo do acervo nacional
- 🔄 **Controle de Empréstimos** — Gestão do ciclo de vida de cada exemplar
- 👥 **Gestão de Clientes** — Cadastro e histórico de usuários da biblioteca
- 🔍 **Consulta de Disponibilidade** — Verificação rápida do status de cada obra
- 📉 **Redução de Perdas** — Controle e rastreamento do acervo

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Uso |
|------------|-----|
| **VB.Net** | Desenvolvimento da aplicação desktop |
| **SQL** | Banco de dados relacional |

---

## 🚀 Como Executar

### Pré-requisitos

- [Visual Studio](https://visualstudio.microsoft.com/) com suporte a VB.Net
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) instalado e rodando

### Passos

1. **Clone o repositório**
   ```bash
   git clone https://github.com/seu-usuario/grimoire.git
   cd grimoire
   ```

2. **Configure o banco de dados**
   - Importe o arquivo `database/grimoire.sql` no seu MySQL
   ```bash
   mysql -u root -p < database/grimoire.sql
   ```

3. **Configure a conexão**
   - Abra o arquivo de configuração e ajuste as credenciais do banco:
   ```
   Server=localhost
   Database=grimoire
   User=root
   Password=sua_senha
   ```

4. **Execute o projeto**
   - Abra a solução `.sln` no Visual Studio
   - Pressione `F5` para compilar e executar

---

## 🗂️ Estrutura do Projeto

```
grimoire/
├── database/
│   └── grimoire.sql        # Script de criação do banco
├── Forms/
│   ├── frmLogin.vb         # Tela de autenticação
│   ├── frmLivros.vb        # Gestão do acervo
│   ├── frmClientes.vb      # Gestão de clientes
│   └── frmEmprestimos.vb   # Controle de empréstimos
├── Models/
│   ├── Livro.vb
│   ├── Cliente.vb
│   └── Emprestimo.vb
├── DAL/                    # Camada de acesso a dados
└── README.md
```

---

## 👥 Autoras

Desenvolvido como projeto acadêmico no curso de **Análise e Desenvolvimento de Sistemas**.

| Nome | GitHub |
|------|--------|
| Aline Michelle | [@minhas-estrelas](https://github.com/minhas-estrelas) |
| Giovanna Vinturi | [@gipissin](https://github.com/gipissin) |
| Julia Simões | [@Jublii](https://github.com/Jublii) |

---

<div align="center">
  <sub>Feito com 🖤 e VB.Net</sub>
</div>
