create table endereco(

ID_endereco integer not null auto_increment primary key,
logradouro varchar(256),
numero integer,
cep integer,
bairro varchar(50),
cidade varchar(30),
estado varchar(20)
);

create table pessoa(

ID_pessoa integer not null auto_increment primary key,
nome varchar(256) not null,
CPF bigint not null,
endereco integer not null,
FOREIGN KEY (endereco) REFERENCES endereco ( ID_endereco )
);

create table telefone_tipo(

id_tipo_telefone integer auto_increment primary key,
tipo varchar(10) 

);

create table telefone(

id_telefone integer auto_increment primary key,
numero integer,
ddd integer,
tipo integer,
FOREIGN KEY (tipo) REFERENCES telefone_tipo (id_tipo_telefone)
);


create table PESSOA_TELEFONE(

	ID_pessoa integer,
	foreign key (ID_PESSOA) references PESSOA (ID_pessoa),
    id_telefone integer,
	foreign key (ID_TELEFONE) references TELEFONE (ID_telefone)
    
);

