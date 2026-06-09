USE projeto_grimore;
GO

-- ==========================================
-- 1. Criação da Tabela de Usuários
-- ==========================================
CREATE TABLE tb_usuarios (
    matricula INT PRIMARY KEY NOT NULL,
    senha VARCHAR(8) NULL,
    pergunta_seg VARCHAR(100) NULL,
    status_conta VARCHAR(100) NULL,
    usuario VARCHAR(100) NULL,
    tipo_usuario VARCHAR(100) NULL
);

-- ==========================================
-- 2. Criação da Tabela de Clientes
-- ==========================================
CREATE TABLE tb_clientes (
    id_cliente INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    telefone VARCHAR(20),
    cpf VARCHAR(14),
    data_nascimento DATE,
    preferencias VARCHAR(100),
    observacoes TEXT,
    foto VARCHAR(255),
    status_cliente VARCHAR(100)
);

-- ==========================================
-- 3. Criação da Tabela de Livros (Acervo)
-- ==========================================
CREATE TABLE tb_livros (
    isbn VARCHAR(15) PRIMARY KEY NOT NULL,
    titulo VARCHAR(100),
    autor VARCHAR(70),
    editora VARCHAR(70),
    area VARCHAR(70),
    quantidade INT,
    cod_pha VARCHAR(10),
    notacao VARCHAR(100),
    etiqueta VARCHAR(100),
    foto VARCHAR(255)
);

-- ==========================================
-- 4. Criação da Tabela de Empréstimos
-- ==========================================
CREATE TABLE tb_emprestimos (
    id_emprestimo INT PRIMARY KEY IDENTITY(1,1),
    id_cliente INT NOT NULL,
    isbn VARCHAR(15) NOT NULL, 
    titulo VARCHAR(200),
    data_emprestimo DATE NOT NULL,
    data_devolucao DATE NOT NULL,
    devolvido BIT DEFAULT 0,
    quantidade INT NOT NULL DEFAULT 1,
    data_devolucao_real DATE NULL,
    qtd_renovacoes INT DEFAULT 0,
    FOREIGN KEY (id_cliente) REFERENCES tb_clientes(id_cliente)
);