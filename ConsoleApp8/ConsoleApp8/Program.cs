namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя");
            string name = Console.ReadLine();
            bool openDoor = false;
            bool isKey = false;
            int a1 = 1;
            int a2 = 2;
            int a3 = 3;
            int tr = 0;
            Console.WriteLine("Вы находитесь в комнате.");
            Console.WriteLine("Чтобы открыть дверь вам надо найти три артефакта, которые активируют статую имеющую ключ от двери.\n");
            while (isKey == false)
            {
                Console.WriteLine("Вы можете: 1.Открыть шкаф 2.Посмотреть под столом 3.Поискать в матрасе 4.Посмотреть под потолком 5.Активировать статую");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {

                    if (a1 == 0)
                    {
                        Console.WriteLine("пусто");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        a1 = 0;
                        tr++;
                    }

                }
                if (choice == 2)
                {

                    if (a2 == 0)
                    {
                        Console.WriteLine("пусто");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        a2 = 0;
                        tr++;
                    }
                }
                if (choice == 3)
                {

                    if (a3 == 0)
                    {
                        Console.WriteLine("пусто");
                    }
                    else
                    {
                        Console.WriteLine("Вы нашли артефакт");
                        a3 = 0;
                        tr++;
                    }
                }
                if (choice == 4)
                {
                    Console.WriteLine("Пусто. Попробуйте поискать в другом месте");
                }
                if (choice == 5)
                {
                    if (tr == 3)
                    {
                        Console.WriteLine("Статуя была активирована.\nВы получили ключ от двери...");
                        isKey = true;
                    }
                    else
                    {
                        Console.WriteLine("Найдите все артефакты");
                    }
                }
            }

            Console.WriteLine("\n Вы выбрались из непонятной комнаты " + name);
            Console.ReadKey();
        }

    }
}