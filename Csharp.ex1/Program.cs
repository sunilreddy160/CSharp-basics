using System;

namespace Csharp.ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			string firstName = "John ";
			string lastName = "Doe";
			string fullName = firstName + lastName;
			string college = "raghu";
			int age = 44;
			int height = 177;
			Console.WriteLine(fullName);
			Console.WriteLine(college);
			Console.WriteLine(age);
			Console.WriteLine(height);
            Console.WriteLine("My name is " + fullName + "." + "I am studying in" + " " +college +  " " + "college." + "My age is " + age + " " + "and"  +" "+ "height" + " " + "is" + " " + height);



		}
	}
}
