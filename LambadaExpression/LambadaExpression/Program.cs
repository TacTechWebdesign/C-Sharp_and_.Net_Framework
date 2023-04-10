using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”.

            List<Employee> EmployeeX = new List<Employee>();

            EmployeeX.Add(new Employee(1, "Leah", "Mack"));
            EmployeeX.Add(new Employee(2, "Ashley", "Tac"));
            EmployeeX.Add(new Employee(3, "Mory", "Bet"));
            EmployeeX.Add(new Employee(4, "Cathy", "Kat"));
            EmployeeX.Add(new Employee(5, "Del", "Beah"));
            EmployeeX.Add(new Employee(6, "Shel", "Doc"));
            EmployeeX.Add(new Employee(7, "Ann", "Curtis"));
            EmployeeX.Add(new Employee(8, "Sarah", "Guddi"));
            EmployeeX.Add(new Employee(9, "Tus", "Kad"));
            EmployeeX.Add(new Employee(10, "Marvin", "Gomez"));

            //3. Using a foreach loop, create a new list of all employees
            //with the first name “Joe”. In your comparison statement,
            //remember to reference the property of the object you are checking.

            List<Employee> EmployeeY = new List<Employee>();

            foreach (Employee Emp in EmployeeX)
            {
                if (Emp.FirstName == "Leah")
                {
                    EmployeeY.Add(Emp);
                }
            }


            foreach (Employee Emp in EmployeeY)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);

            }

            Console.WriteLine("");


            //4. Perform the same action again, but this time with a lambda expression.

            List<Employee> newList = EmployeeX.Where(x => x.FirstName == "Leah").ToList();

            foreach (Employee Emp in newList)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);

            }

            Console.WriteLine("");

            //5. Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> newList2 = EmployeeX.Where(x => x.Id > 5).ToList();

            foreach (Employee Emp in newList2)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);

            }

            Console.ReadLine();
        }
    }
}