using System;
namespace define_a_class_person
{
	public class person
	{
		public string name;
		public int age;

		private string Name { get; set; }
		private int Age { get; set; }


		public person(string name, int age)
		{
			Name = name;
			Age = age;
		}

     
    }
}

