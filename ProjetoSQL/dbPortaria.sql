drop database dbPortaria;

CREATE DATABASE dbPortaria;

use dbPortaria;

create table tbFuncionarios(
codFunc int not null auto_increment,
registroFunc char(7) not null unique,
nome varchar(100),
endereco varchar(100),
numero char(10),
bairro varchar(50),
cidade varchar(50),
cep char(9),
estado varchar(50),
telefone char(10),
cpf char(14) not null unique,
ctps char(8) not null unique,
serie char(4) not null unique,
dataNasc datetime,
sexo char(2) default 'F' check(sexo in('F','M')),
primary key(codFunc)
);

insert into tbFuncionarios(registroFunc,nome,endereco,numero,bairro,cidade,
	cep,estado,telefone,cpf,ctps,serie,dataNasc,sexo)
	values('35247-5','Maria da Esperança da Silva','Av. Dr. Antônio Bento',
		'393','Santo Amaro','São Paulo','04750-000','São Paulo','97563-5241',
		'258.257.247-88','12547','1234','1999-11-11','F');
insert into tbFuncionarios(registroFunc,nome,endereco,numero,bairro,cidade,
	cep,estado,telefone,cpf,ctps,serie,dataNasc,sexo)
	values('38227-9','Paulo Alberto da Nobrega','Rua Caramuru',
		'15A','Santa Cecilia','São Paulo','02536-060','São Paulo','92584-7596',
		'496.528.358-77','12547258','4321','2005-12-05','M');

insert into tbFuncionarios(registroFunc,nome,endereco,numero,bairro,cidade,
	cep,estado,telefone,cpf,ctps,serie,dataNasc,sexo)
	values('39227-8','admin','Rua Caramuru',
		'15A','Santa Cecilia','São Paulo','02536-060','São Paulo','92584-7596',
		'496.584.258-00','12548888','85247','2005-12-05','M');

insert into tbFuncionarios(registroFunc,nome,endereco,numero,bairro,cidade,
	cep,estado,telefone,cpf,ctps,serie,dataNasc,sexo)
	values('69227-8','Caio Miranda da Cunha Silva','Rua José das Praças',
		'155A','Santo André','São Paulo','02836-060','São Paulo','92584-7596',
		'496.584.258-55','58748888','95247','2005-12-05','M');

update tbFuncionarios set nome = 'Maria da Esperança da Silva', endereco = 'Av. Dr. Antônio Bento', 
	numero = '394', bairro = 'Santo Amaro',cidade = 'São Paulo', cep= '04750-000',
	estado = 'São Paulo',telefone ='97563-5241',cpf = '258.257.247-88',
	ctps = '12547', serie = '1234', dataNasc = '1999-11-11',sexo= 'F' where registroFunc = '35247-5';

create table tbUsuarios(
codUsu int not null auto_increment,                         
nome varchar(50) unique,
senha varchar(50) unique,
codFunc int not null,
primary key(codUsu),
foreign key(codFunc)references tbFuncionarios(codFunc)
);



insert into tbUsuarios(nome,senha,codFunc)values('maria.esilva','123456',1);

insert into tbUsuarios(nome,senha,codFunc)values('paulo.anobrega','258741',2);


desc tbFuncionarios;
desc tbUsuarios;

select * from tbFuncionarios;
select * from tbUsuarios where nome='maria.esilva' and senha='123456';

-- Busca pelo registro do funcionário

select * from tbfuncionarios where registroFunc = '"35247-5"';


-- Pesquisa por nome

select * from tbfuncionarios where nome like '%ma%';

-- Excluir por Número de Registro
delete from tbfuncionarios where registroFunc = '35247-5';


select usu.nome, usu.senha from tbFuncionarios as func 
inner join tbUsuarios as usu on usu.codFunc = func.codFunc
where usu.codFunc = 1;

select registroFunc,nome from tbfuncionarios where codFunc = 1;

select usu.nome, usu.senha from tbUsuarios as usu 
inner join tbFuncionarios as func on usu.codFunc = func.codFunc
where codUsu = 1;





select func.registroFunc,func.nome from tbUsuarios as usu
inner join tbfuncionarios as func
on usu.codFunc=func.codFunc;

select usu.nome,usu.senha from tbUsuarios as usu inner join tbfuncionarios as func on usu.codFunc = func.codFunc where func.codFunc = 7;