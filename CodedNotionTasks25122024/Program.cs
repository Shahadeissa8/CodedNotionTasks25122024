using System.Xml.Linq;
using CodedNotionTasks25122024.models;

UserNameClass user = new UserNameClass();

Console.WriteLine("enter your user name ");
user.UserName = Console.ReadLine(); //we dont write name because its private and wont show
Console.WriteLine(user.UserName);  //we dont write name because its private and wont show
user.CorrectUser();

Console.WriteLine("enter your salary: ");
user.salary =Convert.ToDouble( Console.ReadLine());
Console.WriteLine(user.salary);



