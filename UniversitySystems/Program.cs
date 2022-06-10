using System;
using UniversitySystems.Model.Entities;
using UniversitySystems.Repositories.ModelRepos;

namespace UniversitySystems // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepo = new();
            DepartmentRepository departmentRepository = new DepartmentRepository();
            BuildingRepository buildingRepository = new BuildingRepository();
            Departments d1 = new Departments() { Name = "Commerece", HOD = "Abrar" };
            Buildings b1 = new Buildings() { Name = "Building1", Departments = { d1 } };
            
            Departments d2 = new Departments() { Name = "Commerece", HOD = "Abrar" };
             
            Students s1 = new Students() { Id = 1, Name = "Ali", Age = 19, Address = "West coast", Cgpa = 3.1, Email = "my@mail",
                Samester = "6", Departments= d1 };

            Students s2 = new Students() { Id = 2, Name = "Ahmed", Age = 17, Address = "West coast", Cgpa = 3.1, Email = "my@mail", 
                Samester = "6", Departments = d1 };

            Students s3 = new Students()
            {
                Id = 2,
                Name = "Ahmed",
                Age = 17,
                Address = "West coast",
                Cgpa = 3.1,
                Email = "my@mail",

            };
            buildingRepository.Add(b1);
            /*
                  studentRepo.Add(s3);
            var list = studentRepo.GetALL();
            foreach(var i in list)
            {
            Console.WriteLine(string.Join(System.Environment.NewLine,i ));

            }
            studentRepo.ToString();
            */

                // Console.WriteLine(studentRepo.GetALL());
                // Console.WriteLine($"{result}");

            }

    }
}

