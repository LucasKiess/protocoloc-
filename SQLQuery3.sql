/*CRIANDO DATABASE*/
create database sistemaprotocolo;
/*USANDO TABELA*/
use sistemaprotocolo;
/*CRIANDO TABELAS*/
create table usuarios (id int identity(1,1) not null, nome varchar(50) not null, usuario varchar(20) not null, senha varchar(20) not null, nivel varchar(20) not null);
create table locais (id int identity(1,1) not null, nome varchar(30) not null, data_cadastro date not null);
create table convenios (id int identity(1,1) not null, nome varchar(30) not null, data_cadastro date not null);
create table especialidades (id int identity(1,1) not null, nome varchar(30) not null, data_cadastro date not null);
create table tipo_exames (id int identity(1,1) not null, sigla char(1) not null, descricao varchar(30) not null);
create table exames (id int identity(1,1) not null, tipo int not null, numero int not null, paciente varchar(50) not null, medico int not null, convenio int not null, data_entrada date not null);
create table genericos (id int identity(1,1) not null, tipo int not null, descricao varchar(30) not null, data_entrada date not null);
create table tipo_genericos (id int identity(1,1) not null, sigla char(1) not null, descricao varchar(30) not null);
create table medicos (id int identity(1,1) not null, nome varchar(50) not null, crm int not null, especialidade int not null, data_cadastro date not null);
create table envio_material(id int identity(1,1) not null, codigo int not null, status varchar(15) not null, data_previsao date not null, data_envio date not null);
create table entrega_material(id int identity(1,1) not null, codigo int not null, status varchar(15), data_entrega date not null);
create table pacientes (id int identity(1,1) not null, nome varchar(50) not null, idade int not null, telefone varchar(20));

/*ADICIONANDO CAMPOS FALTANTES*/
alter table entrega_material add local_entrega int not null;
alter table usuarios add status varchar(20) not null;
alter table exames add envio int not null;
alter table exames add entrega int not null;

/*ADICIONANDO CHAVES PRIMÁRIAS*/
alter table usuarios add constraint pk_usuarios primary key clustered (id);
alter table locais add constraint pk_locais primary key clustered (id);
alter table convenios add constraint pk_convenios primary key clustered (id);
alter table especialidades add constraint pk_especialidades primary key clustered (id);
alter table tipo_exames add constraint pk_tipo_exames primary key clustered (id);
alter table exames add constraint pk_exames primary key clustered (id);
alter table genericos add constraint pk_genericos primary key clustered (id);
alter table tipo_genericos add constraint pk_tipo_genericos primary key clustered (id);
alter table medicos add constraint pk_medicos primary key clustered (id);
alter table envio_material add constraint pk_envio_material primary key clustered (id);
alter table entrega_material add constraint pk_entrega_material primary key clustered (id);
alter table pacientes add constraint pk_pacientes primary key clustered (id);

/*ADICIONANDO CHAVES ESTRANGEIRAS*/
alter table medicos add constraint fk_medico_especialidade foreign key (especialidade) references especialidades (id);
alter table exames add constraint fk_exames_tipo_exames foreign key (tipo) references tipo_exames (id);
alter table genericos add constraint fk_genericos_tipo_genericos foreign key (tipo) references tipo_genericos (id);
alter table entrega_material add constraint fk_entrega_material_locais foreign key (local_entrega) references locais (id);
alter table exames add constraint fk_exames_paciente foreign key (paciente) references pacientes (id);
alter table exames alter column paciente int not null;
alter table exames alter column envio int null;
alter table exames alter column entrega int null;
alter table exames add constraint fk_exames_medico foreign key (medico) references medicos (id);
alter table exames add constraint fk_exames_convenio foreign key (convenio) references convenios (id);
alter table exames add constraint fk_exames_envios foreign key (envio) references envio_material (id);
alter table exames add constraint fk_exames_entrega foreign key (entrega) references entrega_material (id);


/*INSERINDO MANUALMENTE*/
insert into usuarios values ('Lucas Kiess','lucas','123','Admin','Ativo');
insert into locais values ('Teste',GETDATE());
insert into locais values ('Teste 2',GETDATE());
insert into medicos values ('Diessica Brigoni',55555,7,'22/09/2021 14:37');
insert into pacientes values ('Silmar Germano Kiess',59,'(51)9 86928709');
insert into exames (tipo, numero, paciente, medico, convenio, data_entrada)
values (1,22661,2,3,9,'12/02/2020')	
select * from locais;
select * from usuarios;
select * from convenios;
select * from especialidades;
select * from medicos;
select * from pacientes;
select * from tipo_exames;
select * from exames;
select m.id, m.nome, m.crm, m.especialidade, m.data_cadastro, e.nomeEsp from medicos as m inner join especialidades as e on m.especialidade = e.id order by m.nome asc;
SELECT * FROM usuarios WHERE usuario = 'maria' AND senha = '123' AND status = 'Inativo';
delete from especialidades where id = 2;
CREATE VIEW vw_medicos as select m.id, m.nome, m.crm, m.especialidade, m.data_cadastro, e.nomeEsp from medicos as m inner join especialidades as e on m.especialidade = e.id;
select e.id as ID, e.tipo as Tipo, e.numero as Num, e.paciente as IdPac, e.medico as IdMed, e.convenio as IdCon, e.data_entrada as DataEnt, 
t.sigla as Sigla, 
p.nome as Paci, 
m.nome as Medico, 
c.nome as Convenio 
from exames as e inner join 
tipo_exames as t on e.tipo = t.id
inner join 
pacientes as p on e.paciente = p.id
inner join 
medicos as m on e.medico = m.id inner join 
convenios as c on e.convenio = c.id WHERE p.nome LIKE 'Jo%' ORDER BY p.nome ASC;
delete from exames where id = 3;
select * from pacientes;

select * from vw_medicos;