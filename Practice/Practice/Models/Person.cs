using System;
namespace Practice.Models
{
	public class Person
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public bool IsMarried { get; set; }

		public Person(string name, string surname, int age, bool isMaried)
		{
			Name = name;
			Surname = surname;
			Age = age;
			IsMarried = isMaried;
		}
	}
}

