using System.Runtime.CompilerServices;

namespace Valikud
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Vali 1st 7ni");
            Console.WriteLine(" 1 ThenByLinq");
            Console.WriteLine(" 2 Descending");
            Console.WriteLine(" 3 Select ");
            Console.WriteLine(" 4 SkipWhile");
            Console.WriteLine(" 5 Take");
            Console.WriteLine(" 6 While");
            Console.WriteLine(" 7 if ja else File");
            Console.WriteLine(" 8 forloop");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    ThenByLINQ();
                    break;
                case 2:
                    ThenByDescendingLINQ();
                    break;
                case 3:
                    SelectLINQ();
                    break;
                case 4:
                    SkipWhile();
                    break;
                case 5:
                    Take();
                    break;
                case 6:
                    While();
                    break;
                case 7:
                    FileIfAndELSE();
                    break;
                case 8:
                    ForLoop();  
                    break;
                
                
                default:
                    Console.WriteLine("Vale Valik");
                    break;

            }
            static void ThenByLINQ()
            {
                var thenByResult = PeopleList.peoples
                    .OrderBy(p => p.Name)
                    .ThenBy(y => y.Age);
                Console.WriteLine("ThenBy järgi");
                foreach (var people in thenByResult)
                {
                    Console.WriteLine(people.Name + " " + people.Age);
                }
            }
            static void ThenByDescendingLINQ()
            {
                var thenByResult = PeopleList.peoples
                    .OrderBy(p => p.Name)
                    .ThenByDescending(y => y.Age);
                Console.WriteLine("ThenByDescending järgi");
                foreach (var people in thenByResult)
                {
                    Console.WriteLine(people.Name + " " + people.Age);
                }
            }
            static void SelectLINQ()
            {
                var selectResult = PeopleList.peoples
                    .Select(p => new
                    {
                        Name = p.Name,
                        Age = p.Age
                    });
                foreach (var people in selectResult)
                {
                    Console.WriteLine(people.Name + " " + people.Age);
                }
            }
            static void While() 
            {
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                }
                while (i < 5);
            }
            static void SkipWhile()
            {
                Console.WriteLine("\n\n----------------SkipWhile------------");
                var skip = PeopleList.peoples.SkipWhile(x => x.Age > 18);

                foreach (var item in skip)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                }
            }
             static void Take()
            {
                Console.WriteLine("\n\n----------------Take------------");
                //n'itab kolme esimest

                var take = PeopleList.peoples.Take(3);

                foreach (var item in take)
                {
                    Console.WriteLine(item.Id + " " + item.Name);
                }
            }
           static void FileIfAndELSE()

            {
                try 
                {
                    if (true)
                    {
                        Console.WriteLine("Kirjuta faili läbi konsooli (Õige path)");

                        string filePath = @"C:/Users/opilane/Desktop/HEY/hey.txt";
                        string inputText = Console.ReadLine();

                        File.WriteAllText(filePath, inputText);

                    }
                    else;
                    {
                        Console.WriteLine("Kirjuta faili läbi konsooli (Vale path)");

                        string filePath = @"Y:/Users/opilane/Desktop/HEY/VALE.txt";
                        string inputText = Console.ReadLine();

                        File.WriteAllText(filePath, inputText);
                    }                        
                

                }
                catch (Exception e) 
                {
                    Console.WriteLine("Mingi error");
                    Console.WriteLine(e.Message);
                }
                }
           static void ForLoop()
            {
                Console.WriteLine("Kirjuta numbripüramiidi suurus");
                Console.WriteLine("-----------------------------------------------------");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------");

                for (int i = 0; i <= n; i++)
                {
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("{0}", j);
                    }
                    for (int j = i - 1; j >= 1; j--)
                    {
                        Console.Write("{0}", j);
                    }

                    Console.Write("\n");
                }

            }

        }
    }
}

