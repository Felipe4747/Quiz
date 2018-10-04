create database Quiz;
use Quiz;
create table perguntas(
	id int not null auto_increment,
    pergunta text not null,
    resp1 text not null,
    resp2 text not null,
    resp3 text not null,
    resp4 text not null,
    resp_certa enum('a', 'b', 'c', 'd') not null,
    primary key(id)
);
create table usuario(
	id int not null auto_increment,
    nome varchar(15) not null,
    pontuacao int,
    primary key(id)
);
drop table perguntas;
drop table usuario;
insert into perguntas values
	(null, 'Qual dos gases abaixo não foi utilizado como arma de destruição em massa durante a 1º Guerra?', 'Gás cloro', 'Gás mostarda', 'Gás fosfogênio', 'Gás lacrimogênio', 'd'),
	(null, 'As máscaras de gás eram inúteis contra o gás mostarda. Quais alternativas abaixo descrevem os efeitos do gás?
I - Causava erupções na pele
II - Cegava instantaneamente
III - Causava a ruptura dos vasos sanguíneos
IV - Derretia as máscaras', 'I - II - III, estão corretas', 'II - III - IV, estão corretas', 'I - III - IV, estão corretas', 'Todas estão corretas', 'a'),
	(null, 'Quantos anos durou a guerra?', '6 anos', '3 anos', '8 anos', '4 anos', 'd'),
	(null, 'Quais foram os países que compuseram a tríplice entente (no inicio da 1º Guerra Mundial)?', 'Estados Unidos, Alemanha e Itália', 'Reino Unido, França e Alemanha', 'Reino Unido, Império Russo e França', 'Império Russo, Alemanha e Itália', 'c'),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', ''),
	(null, '', '', '', '', '', '');