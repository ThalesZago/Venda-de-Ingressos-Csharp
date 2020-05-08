
CREATE DATABASE VendaIngressos;
USE VendaIngressos;

CREATE TABLE Pessoa (
    cpf INTEGER PRIMARY KEY NOT NULL,
    tipo VARCHAR(50),
    dataNascimento DATE,
    nome VARCHAR(50),
    telefone VARCHAR(50),
    endereco VARCHAR(50),
    bairro VARCHAR(50),
    cep VARCHAR(50),
    cidade VARCHAR(50),
    estado VARCHAR(50)
);

CREATE TABLE Evento (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    valorRecebido DOUBLE,
    valorGasto DOUBLE,
    nome VARCHAR(50),
    endereco VARCHAR(50),
    dataHora DATE,
    formaPagamento VARCHAR(50)
);

CREATE TABLE gerenteEvento (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    fk_Pessoa_cpf INTEGER,
    fk_Evento_id INTEGER
);

CREATE TABLE Ingresso (
    id INTEGER PRIMARY KEY  AUTO_INCREMENT,
    valor DOUBLE,
    fk_Evento_id INTEGER
);

CREATE TABLE ingressoPessoa (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    fk_Pessoa_cpf INTEGER,
    fk_Ingresso_id INTEGER
);
 
ALTER TABLE Ingresso ADD CONSTRAINT FK_ingresso_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE RESTRICT;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;
 
ALTER TABLE ingressoPessoa ADD CONSTRAINT FK_ingressoPessoa_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE RESTRICT;
 
ALTER TABLE ingressoPessoa ADD CONSTRAINT FK_ingressoPessoa_Ingresso FOREIGN KEY (fk_Ingresso_id) REFERENCES Ingresso (id) ON DELETE SET NULL;