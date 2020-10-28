CREATE DATABASE dbNovoEscolaFuturo;
GO
USE dbNovoEscolaFuturo;
GO
CREATE TABLE funcionario
(
	codFuncionario INT PRIMARY KEY IDENTITY(1,1),
	dtCadastro DATE DEFAULT GETDATE(),
	cpf CHAR(14),
	nome VARCHAR(50),
	telefone VARCHAR(20),
	endereco VARCHAR(50),
	tipo INT NOT NULL
);
--DROP TABLE funcionario
--SELECT * FROM funcionario
CREATE TABLE freqFuncionario
(
	codFreqF				INT PRIMARY KEY IDENTITY(1,1),
	funcionario_codFuncionario INT NOT NULL,
	FOREIGN KEY (funcionario_codFuncionario)
		REFERENCES funcionario (codFuncionario),
	horarioE				VARCHAR(12),
	horarioS				VARCHAR(12),
	intervalo				VARCHAR(20),
	atestado				VARCHAR(20)
);

CREATE TABLE professor
(
	codProfessor			INT PRIMARY KEY IDENTITY(1,1),
	cpf						CHAR(14),
	email					VARCHAR(80),
	senha					VARCHAR(80),
	nome					VARCHAR(50),
	telefone				VARCHAR(20),
	endereco				VARCHAR(50),
	curso					VARCHAR(20)
);
--DROP TABLE professor
--SELECT * FROM professor
CREATE TABLE freqProfessor
(
	codFreqP				INT PRIMARY KEY IDENTITY(1,1),
	professor_codProfessor	INT NOT NULL,
	FOREIGN KEY (professor_codProfessor)
		REFERENCES professor (codProfessor),
	email					VARCHAR(80),
	senha					VARCHAR(80),
	horarioE				VARCHAR(12),
	horarioS				VARCHAR(12),
	intervalo				VARCHAR(20),
	atestado				VARCHAR(20)
);

CREATE TABLE curso
(
	codCurso				INT PRIMARY KEY IDENTITY(1,1),
	nome					VARCHAR(20),
	conteudoCurso			VARCHAR(50),
	planoCurso				VARCHAR(50)
);

CREATE TABLE aluno
(
	codAluno				INT PRIMARY KEY IDENTITY(1,1),
	curso_codCurso			INT,
	FOREIGN KEY (curso_codCurso)
		REFERENCES curso (codCurso),
	rg						CHAR(12),
	nome					VARCHAR(50),
	telefone				VARCHAR(20),
	endereco				VARCHAR(50)
);
--DROP TABLE aluno
--SELECT * FROM aluno
CREATE TABLE freqAluno
(
	codFreqA				INT PRIMARY KEY IDENTITY(1,1),
	aluno_codAluno			INT NOT NULL,
	FOREIGN KEY (aluno_codAluno)
		REFERENCES aluno (codAluno),
	dia						DATE DEFAULT GETDATE(),
	presente				BIT
);

CREATE TABLE pontuacao
(
	codPontuacao			INT PRIMARY KEY IDENTITY(1,1),
	curso_codCurso			INT NOT NULL,
	FOREIGN KEY (curso_codCurso)
		REFERENCES curso (codCurso),
	aluno_codAluno			INT NOT NULL,
	FOREIGN KEY (aluno_codAluno)
		REFERENCES aluno (codAluno),
	descDistribuicao VARCHAR(100),
	pontuacaoFinal INT,
);

CREATE TABLE diretor
(
	codDiretor				INT PRIMARY KEY IDENTITY(1,1),
	nome					VARCHAR(50),
	cpf						CHAR(14),
	email					VARCHAR(80),
	senha					VARCHAR(80)
);
INSERT INTO diretor VALUES('diretor','11111111111111','diretor@gmail.com','123');
SELECT * FROM diretor
CREATE TABLE coordenador
(
	codCoordenador			INT PRIMARY KEY IDENTITY(1,1),
	nome					VARCHAR(50),
	cpf						CHAR(14),
	email					VARCHAR(80),
	senha					VARCHAR(80)
);
CREATE TABLE secretaria
(
	codSecretaria			INT PRIMARY KEY IDENTITY(1,1),
	nome					VARCHAR(50),
	cpf						CHAR(14),
	email					VARCHAR(80),
	senha					VARCHAR(80)
);
-- drop database dbEscolaFuturo
-- use master