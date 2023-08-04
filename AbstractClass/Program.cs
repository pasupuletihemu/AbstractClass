using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account a;
            Savings Customer1 = new Savings(9001, "vamsi", 1000);
            Customer1.ShowAccount();
            Customer1.Deposit(900);
            Customer1.WithDraw(1500);
            Customer1.WithDraw(200);

            Salary emp1 = new Salary(8101, "Hemanth", 2000);
            emp1.ShowAccount();
            emp1.Deposit(1000);
            emp1.WithDraw(2600);
            emp1.WithDraw(600);

            Console.WriteLine(Customer1.GetHashCode() +"   " + emp1.GetHashCode());

            a = Customer1;
            Console.WriteLine(a.GetHashCode() + "   " + a.GetHashCode());
            a.ShowAccount();
            a.Deposit(200);
            a.WithDraw(100);

            a = emp1;
            Console.WriteLine(a.GetHashCode() + "   " + a.GetHashCode());
            a.ShowAccount();
            a.Deposit(200);
            a.WithDraw(100);


        }
    }
}
