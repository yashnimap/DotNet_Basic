using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
public class Person {
public string name;

public void introduce(string to) {
Console.WriteLine("Hii {0}, I am {1}",to , name);
}
}
internal class Program
{
static void Main(string[] args)
{
var person = new Person();
person.name = "johan";
person.introduce("Yash");

}
}
}
