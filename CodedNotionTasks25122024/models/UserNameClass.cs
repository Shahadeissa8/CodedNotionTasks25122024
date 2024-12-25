using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedNotionTasks25122024.models
{
    internal class UserNameClass
    {
        private string name;
        public string UserName
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else {
                    Console.WriteLine("please enter user name: ");

                   }
            }
        }
        public void CorrectUser()
        {
            Console.WriteLine("your username is " + name);//int the else, we saved the value inside name from above, hence why we get it here when we call it in the main
        }

        private double Salary;
        public double salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value >= 350 && value <= 900)
                {
                    Salary = value;
                }
                else
                {
                    Console.WriteLine("Salary is out of range!");
                }
            }
        }
    }
}
