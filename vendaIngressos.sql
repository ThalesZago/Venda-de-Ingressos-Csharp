drop database vendaingressos;
CREATE DATABASE VendaIngressos;
USE VendaIngressos;

CREATE TABLE Pessoa (
    cpf bigint(50) PRIMARY KEY NOT NULL,
    tipo VARCHAR(50),
    dataNascimento DATE,
    nome VARCHAR(50),
    email VARCHAR(50),
    telefone VARCHAR(50),
    endereco VARCHAR(50),
    bairro VARCHAR(50),
    cep VARCHAR(50),
    cidade VARCHAR(50),
    estado VARCHAR(50),
    username VARCHAR(50),
    passw VARCHAR(50),
    isAdmin VARCHAR(5),
    imgUser LONGBLOB
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
    fk_Pessoa_cpf bigint(50),
    fk_Evento_id INTEGER
);

CREATE TABLE Ingresso (
    id INTEGER PRIMARY KEY  AUTO_INCREMENT,
    valor DOUBLE,
    fk_Evento_id INTEGER
);

CREATE TABLE ingressoPessoa (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    fk_Pessoa_cpf bigint(50),
    fk_Ingresso_id INTEGER
);
 
ALTER TABLE Ingresso ADD CONSTRAINT FK_ingresso_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE RESTRICT;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;
 
ALTER TABLE ingressoPessoa ADD CONSTRAINT FK_ingressoPessoa_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE RESTRICT;
 
ALTER TABLE ingressoPessoa ADD CONSTRAINT FK_ingressoPessoa_Ingresso FOREIGN KEY (fk_Ingresso_id) REFERENCES Ingresso (id) ON DELETE SET NULL;

insert into pessoa(cpf, tipo, nome, username, passw, isAdmin) values (45144198762, "Pessoa Jurídica", "Thales Zago de Souza", "Thales_comH", "123456A@", "ADMIN");
insert into pessoa(cpf, tipo, nome, telefone, endereco, bairro, cep, cidade, estado, username, passw, isAdmin) values (12345678911, "Pessoa Física", "Adilson Baladeiro", "981685542", "Rua das Flores, 1020", "Jardim dos Jardins", "13145789", "Holambra", "São Paulo", "AdilBalada", "balada123", "USER");
insert into pessoa(cpf, tipo, nome, telefone, endereco, bairro, cep, cidade, estado, username, passw, isAdmin) values (52487478511, "Pessoa Física", "José Roberto", "78412459", "Rua dos Girassóis, 4000", "Jardim Villagio", "13145789", "Campinas", "São Paulo", "jo234", "usere", "USER");
