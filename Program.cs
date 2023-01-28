string[] Massive;
            Console.WriteLine("Введите массив строк через пробел");
            string stroka = Console.ReadLine();
 Massive = stroka.Split(' ');
            var result = new string[Massive.Length];
            var Size = 0;
 foreach (var line in Massive)
            {
                if (line.Length <= 3)
                {
                    result[Size] = line;
                    Size++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, result, 0, Size));
            Console.ReadKey(true);