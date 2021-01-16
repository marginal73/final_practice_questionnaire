using System;

namespace final_practice_questionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут:");
            var name = Console.ReadLine();
            Console.Write("Сколько вам лет:");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вас зовут {0}, вам {1} лет", name, age);
            Console.Write("Когда вы родились:");
            var birthday = Console.ReadLine();
            Console.WriteLine("Вы родились {0}", birthday);

        }
    }
}
