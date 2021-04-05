using System;

namespace Modul6
{
	class User
	{
		private int age;
		public int Age
		{
			get
			{
				return age;
			}
			set
			{
				if (value < 18)
				{
					Console.WriteLine("Возраст должен быть не меньше 18");
				}
				else
				{
					age = value;
				}
			}
		}

		private string eMail;
		public string EMail
        {
			get 
			{
				return eMail;
			}
			set
			{
				if (value.Length < 3 || !value.Contains('@'))
				{
					Console.WriteLine("Не верно введён адрес иМайла");
				}
				else
				{
					eMail = value;
				}
			}
		}

		private string login;
		public string Login
		{ 
			get
            {
				return login;
            }
			set
            {
				if (value.Length <= 3 )
				{
					Console.WriteLine("Не верно введён логин");
				}
				else
				{
					login = value;
				}
			}
		}
	}
	class Circle
	{
		public double radius;

		public double Square()
		{
		}

		public double Length()
		{
		}
	}
	class Triangle
	{
		public int a;
		public int b;
		public int c;
		public int A
		{
			get { return a; }
			set
			{
				if (value > 0 && b + c > value)
				{
					a = value;
				}
			}
		}
		public int B
		{
			get { return b; }
			set
			{
				if (value > 0 && a + c > value)
				{
					b = value;
				}
			}
		}
		public int C
		{
			get { return c; }
			set
			{
				if (value > 0 && a + b > value)
				{
					c = value;
				}
			}
		}
		public double Square()
		{
		}
		public double Perimeter()
		{
		}
	}
	class Square
	{
		public int side;

		public double Square()
		{
		}

		public double Perimeter()
		{
		}
	}
	enum TurnDirection
	{
		None = 0,
		Left,
		Right
	}
	class Car
	{
		private double Fuel;
		private int Mileage;
		private string color;
		private TurnDirection turn;

		public Car()
		{
			Fuel = 50;
			Mileage = 0;
			color = "White";
		}

		private void Move()
		{
			// Move a kilometer
			Mileage++;
			Fuel -= 0.5;
		}

		private void Turn(TurnDirection direction)
		{
			turn = direction;
		}

		public void FillTheCar()
		{
			Fuel = 50;
		}

		public string GetColor()
		{
			return color;
		}

		public void ChangeColor(string newColor)
		{
			if (color != newColor)
				color = newColor;
		}

		public bool IsTurningLeft()
		{
			return turn == TurnDirection.Left;
		}

		public bool IsTurningRight()
		{
			return turn == TurnDirection.Right;
		}
	}

	class Program
    {
        static void Main(string[] args)
        {

        }

 
    }
}

