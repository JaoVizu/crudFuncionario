create database atividade;

use atividade;

create table tb_departamento(
	id_departamento INT primary key auto_increment,
	nome varchar(60),
	cidade varchar(40),
	fg_ativo int
);

create table tb_funcionario(
	id_funcionario int primary key auto_increment,
	id_gerente int,
	id_departamento int,
	dt_nascimento DATE,
	salario numeric,
	cargo varchar(60),
	fg_ativo int,
	constraint fk_departamento foreign key (id_departamento) references tb_departamento (id_departamento)
);

create table tb_grade_salario(
	id_salario int primary key auto_increment,
	min_salario numeric,
	max_salario numeric,
	fg_ativo int
)

select * from tb_departamento;

