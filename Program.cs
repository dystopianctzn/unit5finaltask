using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit5finaltask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayUserdata();
        }

        public static (string, string, int, string[], string[]) EnterUserdata()
        {
            (string Name, string LastName, int Age, string[] PetNames, string[] FavColors) User;

            Console.Write("Введите ваше имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            string age;
            int intage;
            do
            {
                Console.Write("Введите свой возраст: ");
                age = Console.ReadLine();
            }
            while (CheckNum(age, out intage));
            User.Age = intage;


            Console.Write("Введите количество своих питомцов, если их нет, то напишите 0: ");
            int petCount = Convert.ToInt32(Console.ReadLine());
            string[] tempPetCount = new string[petCount];
            if (petCount == 0)
                Console.WriteLine("У вас нет питомцев");
            else
            {
                Console.WriteLine($"У вас {petCount} питомцев");
                Console.WriteLine("Напишите их кличики: ");
                for (int i = 0; i < tempPetCount.Length; i++)
                    tempPetCount[i] = Console.ReadLine();
            }
            User.PetNames = tempPetCount;


            Console.Write("Введите количество любимых цветов: ");
            int favColorsCount = Convert.ToInt32(Console.ReadLine());
            string[] tempFavColors = new string[favColorsCount];
            Console.WriteLine("Напишите свои любимые цвета: ");

            for (int i = 0; i < tempFavColors.Length; i++)
                tempFavColors[i] = Console.ReadLine();

            User.FavColors = tempFavColors;
            return User;
        }


        static void DisplayUserdata()
        {
            var Userdata = EnterUserdata();


            Console.WriteLine("\nВаши данные\n");

            Console.WriteLine($"Ваше имя: {Userdata.Item1}, ваша фамилия: {Userdata.Item2}, ваш возраст {Userdata.Item3}.\n");


            string[] petNames;
            petNames = Userdata.Item4;
            if (petNames.Length > 0)
            {
                
                Console.WriteLine("Имена ваших питомцев:");
                for (int i = 0; i < petNames.Length; i++)
                    Console.Write(petNames[i] + " | ");
                Console.WriteLine();

            }
            else
                Console.WriteLine("У вас нет питомцев");
            Console.WriteLine();


            string[] favColors;
            favColors = Userdata.Item5;
            Console.WriteLine("Ваши любимые цвета: ");
            for (int i = 0; i < favColors.Length; i++)
                Console.Write(favColors[i] + " | ");

        }


        static bool CheckNum(string number, out int corrnubmer)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {

                    corrnubmer = intnum;

                    return false;
                }
            }
            {
                corrnubmer = 0;
                Console.WriteLine("Введите правильно значение!");
                return true;

            }
        }

    }
}
