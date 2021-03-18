using System;

class MainClass
{
    public static void Main(string[] args)

    // ===================================== Задание 4.5
    
    {
        (string Name, string FName, string Login, int LengLogin, bool FPet, int Age, string[] FavColor ) User;
        User.FavColor = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.FName = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LengLogin = User.Login.Length;

            Console.WriteLine("Есть ли у Вас животные ?  Да или Нет");
            User.FPet = Console.ReadLine() == "Да" ? true : false;

            Console.WriteLine("Введите возраст пользователя");
            
            User.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int j = 0; j < User.FavColor.Length; j++)
            {
                User.FavColor[j] = Console.ReadLine();
            }
            //User.FavColor[0] = Console.ReadLine();
            //User.FavColor[1] = Console.ReadLine();
            //User.FavColor[2] = Console.ReadLine();
        }


        //Console.WriteLine("Моё имя: {0}", name);
        //= Console.ReadLine();
        //= Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();
    }

}