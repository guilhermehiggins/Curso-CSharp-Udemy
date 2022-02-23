// Exercicio proposto:
//
// Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
// Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser.
// Assim, o número total de alunos de um instrutor nãoé simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.
// O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
// Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele

using System;
using System.Collections.Generic;
using ExerciciosConjuntos.Entities;

namespace ExerciciosConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Course> courseA = new HashSet<Course>();
            HashSet<Course> courseB = new HashSet<Course>();
            HashSet<Course> courseC = new HashSet<Course>();

            Console.Write("How many students for course A? ");
            int quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student user = new Student(id);
                courseA.Add(new Course(user));
            }

            Console.Write("How many students for course B? ");
            quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student user = new Student(id);
                courseB.Add(new Course(user));
            }

            Console.Write("How many students for course C? ");
            quantity = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantity; i++)
            {
                int id = int.Parse(Console.ReadLine());
                Student user = new Student(id);
                courseC.Add(new Course(user));
            }

            HashSet<Course> studentList = new HashSet<Course>(courseA);
            studentList.UnionWith(courseB);
            studentList.UnionWith(courseC);

            Console.WriteLine("Total students: " + studentList.Count);
        }
    }
}
