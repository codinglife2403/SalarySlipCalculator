using System;

namespace ConsoleApp2
{
    class Project2
    {
        static void Main(string[] args)
        {
            SalarySlip employeeSalary = new SalarySlip();
            employeeSalary.designation = "Employee";
            OthersSalarySlip engineers = new OthersSalarySlip();
            engineers.designation = "Engineer";
            engineers.fuelCost = 100;
            engineers.medicalAllowance = 500;
            OthersSalarySlip manager = new OthersSalarySlip();
            manager.designation = "Manager";
            manager.fuelCost = 250;
            manager.medicalAllowance = 1000;
            OthersSalarySlip analysts = new OthersSalarySlip();
            analysts.designation = "Analyst";
            analysts.fuelCost = 150;
            analysts.medicalAllowance = 800;
            Console.WriteLine("Enter your designation:");
            string desig = Console.ReadLine();
            Console.WriteLine("Your gross salary=");
            if (desig == employeeSalary.designation)
            {
                employeeSalary.CalculateSalary();
            }
            if (desig == engineers.designation)
            {
                engineers.CalculateSalary(engineers.fuelCost, engineers.medicalAllowance);
            }
            if (desig == manager.designation)
            {
                engineers.CalculateSalary(manager.fuelCost, manager.medicalAllowance);
            }
            if (desig == analysts.designation)
            {
                engineers.CalculateSalary(analysts.fuelCost, analysts.medicalAllowance);
            }

        }
             class SalarySlip
        {
            public string designation;
            protected static int baseSalary = 1500;
            public  void CalculateSalary()
            {

                Console.WriteLine(baseSalary);
            }
        }
        class OthersSalarySlip : SalarySlip
        {
            public int fuelCost;
            public int medicalAllowance;
           public  void CalculateSalary(int fuel, int medical)
            { int salary;
                salary = baseSalary + fuel + medical;
                Console.WriteLine(salary);
            }

        }

        }
    }

