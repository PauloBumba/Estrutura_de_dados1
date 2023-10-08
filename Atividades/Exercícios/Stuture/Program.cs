using System;
using System.Collections.Generic;

// Classe que representa um departamento.
class Department
{
    public string Name { get; set; }
    public List<Department> SubDepartments { get; set; }

    public Department(string name)
    {
        Name = name;
        SubDepartments = new List<Department>();
    }

    public void AddSubDepartment(Department subDepartment)
    {
        SubDepartments.Add(subDepartment);
    }

    public void Display(int level = 0)
    {
        string indent = new string(' ', level * 4);
        Console.WriteLine(indent + Name);
        foreach (var subDepartment in SubDepartments)
        {
            subDepartment.Display(level + 1);
        }
    }
}

class Program
{
    static void Main()
    {
        // Crie os departamentos
        Department ceo = new Department("CEO");
        Department cto = new Department("CTO");
        Department hr = new Department("Recursos Humanos");
        Department engineering = new Department("Engenharia");
        Department marketing = new Department("Marketing");

        // Construa a hierarquia
        ceo.AddSubDepartment(cto);
        ceo.AddSubDepartment(hr);
        cto.AddSubDepartment(engineering);
        cto.AddSubDepartment(marketing);

        // Exiba o organograma
        ceo.Display();
    }
}