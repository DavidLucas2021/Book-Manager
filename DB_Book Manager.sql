 --CRIA UM NOVO BANCO DE DADOS 
create database DB_Livraria

--SETANDO O BANCO DE DADOS PARA TRABALHAR
use DB_Livraria

--CRIANDO UMA TABELA 
create table TBLAtendente
(	
	--PRIMARY KEY DEFINE QUE A TABELA TERÁ UM CÓDIGO (NUMERAÇÃO)
	--PARA CADA LINHA E COLUNA. ASSIM SE TORNA FACIL O ACESSO 
	--E TAMBEM É GARANTIDO A INTEGRIDADE DO DADO////IDENTITY
	--DEFINE QUE ESSE CÓDIGO SERÁ AUTOMATICO E SEQUÊNCIAL (1,2,3...)
	cd_Atedente int primary key identity,
	--O TIPO VARCHAR ACEITA CARACTERS ALFANUMERICOS///NOT NULL
	--DEFINE QUE O CAMPO É OBRIGATORIO - NÃO PODE SER NULO
	ds_Login varchar(20) not null,
	ds_Senha char(8) not null,
	nm_Atendente varchar(60) not null
)

--INSERINDO DADOS NA TABELA ATENDENTE NOS CAMPOS DEFINIDOS
insert into TBLAtendente
(ds_Login,ds_Senha,nm_Atendente)
values('David','am@156','David Lucas')

--DELETANDO UMA SEGUNDA LINHA QUE CRIEI 
--COM O MESMO DADOS DA PRIMEIRA LINHA 
--ATRAVES DO CÓDIGO ABAIXO(2 LINHAS ABAIXOS).
delete FROM TBLAtendente
WHERE cd_Atedente = '3';

--SELECIONANDO TODOS OS CAMPOS DA TABELA ATENDENTE
--AO EXECUTAR É MOSTRADO A TABELA ATENDENTE COMO UM TODO
select * from TBLAtendente
--where ds_Login = 'David' and ds_Senha = 'am@156'



--CRIANDO A TABELA PARA CRIENTE
create table TBLcliente 
(
	cd_Cliente int primary key identity,
	nm_Cliente varchar(60) not null,
	ds_Email varchar(60) not null,
	no_CPF char(11) null,
	no_CNPJ char(14) null,
	nm_Logradouto varchar(60) not null,
	no_Logradouro varchar(5) not null,
	ds_Complemento varchar(20) null,
	nm_Bairro varchar(20) not null,
	nm_Cidade varchar(20) not null,
	sg_UF char(2) not null,
	no_CEP char(8) not null

)
select * from TBLcliente

--CRIANDO TABELA DE TELEFONE 
create table TBLtelefone
(
	cd_Cliente int ,
	no_Telefone char(11)
	primary key(cd_Cliente,no_Telefone)
	--TRECHO QUE INFORMA QUE O CD_CLIENTE DO TBCLIENTE TEM REFERÊNCIA COM O 
	--CD_CLIENTE DO TBLTELEFONE
	foreign Key(cd_Cliente) references TBLcliente(cd_Cliente)
)

select * from TBLcliente
select * from TBLtelefone