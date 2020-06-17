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
    valorIngresso DOUBLE,
    valorTaxas DOUBLE,
    nome VARCHAR(50),
    endereco VARCHAR(50),
    dataHora VARCHAR(50),
    imgEvent LONGBLOB
);

CREATE TABLE gerenteEvento (
    id INTEGER PRIMARY KEY AUTO_INCREMENT,
    fk_Pessoa_cpf bigint(50),
    fk_Evento_id INTEGER
);

CREATE TABLE Ingresso (
    id INTEGER PRIMARY KEY  AUTO_INCREMENT,
    valor DOUBLE,
    quantidade INTEGER,
    formaPagamento VARCHAR(50),
    fk_Pessoa_cpf bigint(50),
    fk_Evento_id INTEGER
);
 
ALTER TABLE Ingresso ADD CONSTRAINT FK_ingresso_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;

ALTER TABLE Ingresso ADD CONSTRAINT FK_ingresso_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE SET NULL;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Pessoa FOREIGN KEY (fk_Pessoa_cpf) REFERENCES Pessoa (cpf) ON DELETE RESTRICT;
 
ALTER TABLE gerenteEvento ADD CONSTRAINT FK_gerenteEvento_Evento FOREIGN KEY (fk_Evento_id) REFERENCES Evento (id) ON DELETE SET NULL;

INSERT INTO pessoa(cpf, tipo, nome, username, passw, isAdmin) VALUES (45144198762, "Pessoa Jurídica", "Thales Zago de Souza", "Thales_comH", "123456A@", "ADMIN");
INSERT INTO pessoa(cpf, tipo, nome, telefone, endereco, bairro, cep, cidade, estado, username, passw, isAdmin) VALUES (12345678911, "Pessoa Física", "Adilson Baladeiro", "981685542", "Rua das Flores, 1020", "Jardim dos Jardins", "13145789", "Holambra", "São Paulo", "AdilBalada", "balada123", "USER");
INSERT INTO pessoa(cpf, tipo, nome, telefone, endereco, bairro, cep, cidade, estado, username, passw, isAdmin) VALUES (52487478511, "Pessoa Física", "José Roberto", "78412459", "Rua dos Girassóis, 4000", "Jardim Villagio", "13145789", "Campinas", "São Paulo", "jo234", "usere", "USER");

INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (50000, 45000, 20.00, 10.00, "Alloha Festival", "Jardim Santo Antônio 105", "2020-08-05 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (1000000, 900000, 80.00, 10.00, "Woodstrofe", "Jd Cambuí Campinas 400", "2020-07-06 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (400000, 200000, 35.00, 10.00, "LolaEletro", "Rua Peaky Blinders 202", "2020-06-08 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (30000, 30000, 10.00, 10.00, "NewRock Festival", "Rua dos Bandeirantes 303", "2020-11-12 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (80000, 70000, 80.00, 10.00, "Live Ades", "Rua Itaquera 1005", "2020-10-04 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (150000, 140000, 55.00, 10.00, "Fuji Rock Festival", "Lago da Serra 1030", "2020-05-04 22:00:00");
INSERT INTO evento(valorRecebido, valorGasto, valorIngresso, valorTaxas, nome, endereco, dataHora) VALUES (100000, 90000, 23.00, 10.00, "Marcha Para Jesus", "Praça Arautos da Paz, 1000 Campinas", "2020-09-08 22:00:00");

INSERT INTO gerenteEvento(fk_Pessoa_cpf, fk_Evento_id) VALUES (45144198762, 1);
INSERT INTO gerenteEvento(fk_Pessoa_cpf, fk_Evento_id) VALUES (45144198762, 2);
INSERT INTO gerenteEvento(fk_Pessoa_cpf, fk_Evento_id) VALUES (45144198762, 3);
INSERT INTO gerenteEvento(fk_Pessoa_cpf, fk_Evento_id) VALUES (45144198762, 4);
INSERT INTO gerenteEvento(fk_Pessoa_cpf, fk_Evento_id) VALUES (45144198762, 6);