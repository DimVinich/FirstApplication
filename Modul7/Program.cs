using System;

namespace Modul7
{


	class Program
    {
        static void Main(string[] args)
        {
			D d = new D();
			E e = new E();

			d.Display();
			((A)e).Display();
			((B)d).Display();
			((A)d).Display();
			//Console.WriteLine("Hello World!");
		}
    }

	class BaseClass
	{
		protected string Name;
		public virtual int Counter
		{
			get;
			set;
		}
		public BaseClass(string name)
		{
			Name = name;
		}

		public virtual void Display()
        {
			Console.WriteLine("Метод класса BaseClass");
        }
	}
	class DerivedClass : BaseClass
	{
		public string Description;
		private int counter;
		public override int Counter
        {
            get
            {
				return counter;
            }
            set
            {
				if (value >= 0 )
                {
					counter = value;
                }
            }
        }

		public DerivedClass(string name, string description):base(name)
        {
			Description = description;
        }

		public DerivedClass(string name, string description, int counter):base(name)
        {
			Description = description;
			Counter = counter;
		}

		//  Как вариант можно переписать второй конструктор
		//public DerivedClass(string name, string description, int counter) : this(name, description)
		//{
		//	Counter = counter;
		//}
		public override void Display()
		{
			base.Display();
			Console.WriteLine("Метод класса DerivedClass");
		}

	}


	class Employee
	{
		public string Name;
		public int Age;
		public int Salary;
	}
	class ProjectManager : Employee
	{
		public string ProjectName;
	}
	class Developer : Employee
	{
		public string ProgrammingLanguage;
	}

	class Car
	{
		public int Mileage;

		public Car()
		{
			Mileage = 0;
		}

		public virtual void Move()
		{
			Console.WriteLine("Вызван метод Move класса Car");
			Mileage++;
		}
	}
	enum FuelType
	{
		Gas = 0,
		Electricity
	}
	class HybridCar : Car
	{
		public FuelType FuelType;
		public double Gas;
		public double Electricity;

		public HybridCar()
		{
			Electricity = 50;
			Gas = 50;
		}

		public override void Move()
		{
			Console.WriteLine("Вызван метод Move класса HybridCar");
			Mileage++;     // правильней будет  base.Move(); !!

			switch (FuelType)
			{
				case FuelType.Gas:
					Gas -= 0.5;
					break;
				case FuelType.Electricity:
					Electricity -= 0.5;
					break;
			}
		}

		public void ChangeFuelType(FuelType type)
		{
			FuelType = type;
		}
	}

	class A
    {
		public virtual void Display() {
			Console.WriteLine("A");
		}
    }
	class B : A
    {
		public new void Display() {
			Console.WriteLine("B");
		}
    }
	class C : A
    {
        public override void Display()
        {
			Console.WriteLine("C");
		}
	}

	class D : B
    {
		public new void Display(){
			Console.WriteLine("D");
		}
	}

	class E : C
    {
		public new void Display(){
			Console.WriteLine("E");
		}
	}

}
