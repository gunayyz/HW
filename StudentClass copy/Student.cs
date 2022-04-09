using System;
namespace _30mart.Models
{
	public class Student
	{
		//1.1 Student class
		//- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq
		// və hər dəfə yeni bir Student obyekt yaradıldıqda avtomatik bir vahid artacaq.
		//- Name
		//- Surname
		//- Age
		//- Point
		//- ShowInfo() - student-in bütün məlumatlarını geriyə qaytaracaq.
		public int Id;
		public string Name;
		public string Surname;
		public int Age;
		public int Point;

        public Student(int id,int age, string name, string surName, int point)
        {
			if (Name == "" || Surname == "" || Age == 0 || Point == 0)

            {
				Console.WriteLine("you can't create an object without name, surname,point , age values.");
			}
			else
			{
				Id = id;
				Name = name;
				Surname = surName;
				Age = age;
				Point = point;
			}
        }	
		public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nPoint: {Point}");
		}
	}
}