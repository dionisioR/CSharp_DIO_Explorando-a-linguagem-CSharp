﻿using CSharp_DIO_Explorando_a_linguagem_CSharp.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Anakin";
// p1.Idade = 11;
// p1.Sobrenome = "Skywalker";
// p1.Apresentar();

Pessoa p1 = new Pessoa();
p1.Nome = "Anakin";
p1.Sobrenome = "Skywalker";

Pessoa p2 = new Pessoa();
p2.Nome = "Luke";
p2.Sobrenome = "Skywalker";

Pessoa p3 = new Pessoa();
p3.Nome = "Leia";
p3.Sobrenome = "Organa";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";

cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);

cursoDeIngles.ListarAlunos();


