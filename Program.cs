using System;

namespace Program
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("Добро пожаловать в магазин");
            Console.ReadLine();
            int balance = 10000;
            bool isProgramRunning = true;
            while (isProgramRunning)
            {
                Console.Clear();
                Console.WriteLine(" 1-Товары \n 2-кошелёк \n 3-Тележка \n 4-выход");
                int choice = 0;
                if (Int32.TryParse(Console.ReadLine(), out choice) == false) { }
                switch (choice)
                {
                    case 1:
                        bool isChoosing = true;
                        while (isChoosing)
                        {
                            Console.Clear();
                            Console.WriteLine(" 1-Молочка \n 2-Фрукты \n 3-Выпечка \n 4-Выйти");
                            int productsChoice = 0;
                            if (Int32.TryParse(Console.ReadLine(), out productsChoice) == false) { }
                            Console.Clear();
                            switch (productsChoice)
                            {
                                case 1:
                                    string[] MilkyProducts = new string[4]{
                                        "1_сыр-100$",
                                        "2_молоко-300$",
                                        "3_творог-89$",
                                        "4_сметана-50$"
                                    };

                                    for (int i = 0; i < MilkyProducts.Length; i++)
                                    {
                                        Console.WriteLine(MilkyProducts[i]);
                                    }
                                    int choicedairy_products = 0;
                                    if (Int32.TryParse(Console.ReadLine(), out choicedairy_products) == false) { }
                                    string productName = "";
                                    int price = 0;
                                    switch (choicedairy_products)
                                    {
                                        case 1:
                                            productName = "сыр";
                                            price = 100;
                                            break;
                                        case 2:
                                            productName = "молоко";
                                            price = 300;
                                            break;
                                        case 3:
                                            productName = "творог";
                                            price = 89;
                                            break;
                                        case 4:
                                            productName = "сметана";
                                            price = 50;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Вы ввели неверное значение");
                                            Console.ReadLine();
                                            break;
                                    }
                                    Console.Clear();
                                    Console.WriteLine($"Вы купили {productName} за {price}$");
                                    balance -= price;
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.WriteLine("Вы ввели неверное значение");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    string[] fruits = new string[4]{
                                    "1_яблоки-40$",
                                    "2_груши-40$",
                                    "3_манго-89$",
                                    "4_киви-50$"
                                    };
                                    for (int i = 0; i < fruits.Length; i++)
                                    {
                                        Console.WriteLine(fruits[i]);
                                    }
                                    int fruits_products = 0;
                                    if (Int32.TryParse(Console.ReadLine(), out fruits_products) == false) { }
                                    productName = "";
                                    price = 0;
                                    switch (fruits_products)
                                    {
                                        case 1:
                                            productName = "яблоки";
                                            price = 40;
                                            break;
                                        case 2:
                                            productName = "груши";
                                            price = 40;
                                            break;
                                        case 3:
                                            productName = "манго";
                                            price = 89;
                                            break;
                                        case 4:
                                            productName = "киви";
                                            price = 50;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Вы ввели неверное значение");
                                            Console.ReadLine();
                                            break;
                                    }
                                    Console.Clear();
                                    Console.WriteLine($"Вы купили {productName} за {price}$");
                                    balance -= price;
                                    Console.ReadLine();
                                    break;

                                case 3:
                                    string[] bakery_products = new string[4]{
                                        "1_булочка с повидлом-70$",
                                        "2_пицца-90$",
                                        "3_сосиска в тесте-89$",
                                        "4_эчпочмак-50$"
                                    };

                                    for (int i = 0; i < bakery_products.Length; i++)
                                    {
                                        Console.WriteLine(bakery_products[i]);
                                    }
                                    int bakery_products_products = 0;
                                    if (Int32.TryParse(Console.ReadLine(), out bakery_products_products) == false) { }
                                    productName = "";
                                    price = 0;
                                    switch (bakery_products_products)
                                    {
                                        case 1:
                                            productName = "булочка с повидлом";
                                            price = 70;
                                            break;
                                        case 2:
                                            productName = "пицца";
                                            price = 90;
                                            break;
                                        case 3:
                                            productName = "сосиска в тесте";
                                            price = 89;
                                            break;
                                        case 4:
                                            productName = "эчпочмак";
                                            price = 50;
                                            break;
                                        default:
                                            Console.Clear();
                                            Console.WriteLine("Вы ввели неверное значение");
                                            Console.ReadLine();
                                            break;
                                    }
                                    Console.Clear();
                                    Console.WriteLine($"Вы купили {productName} за {price}$");
                                    balance -= price;
                                    Console.ReadLine();
                                    break;

                                case 4:
                                    isChoosing = false;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"{balance}$");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Вы потеряли тележку");
                        Console.ReadLine();
                        break;
                    case 4:
                        isProgramRunning = false;
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверное значение");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}