namespace TestCleanCode
{
    using System;
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var name = "Thiago Caldeira";
            var resultEven = new StringBuilder();
            var resultOdd = new StringBuilder();
            var words = name.Split(' ');

            if (words.Length < 1 || string.IsNullOrEmpty(name))
                Console.WriteLine("Error: Menor que uma palavra");
            else if (words.Length > 3)
                Console.WriteLine("Error: Maior que três palavras");
            else
            {
                foreach (var word in words)
                {
                    for (int i = 0; i <= word.Length - 1; i++)
                    {
                        if (i % 2 == 0)
                            resultOdd.Append(word[i]);
                        else
                            resultEven.Append(word[i]);
                    }
                }
                var results = words.Length % 2 == 0 ? resultOdd.ToString() : resultEven.ToString();
                var result = string.Empty;
                for (int i = 0; i <= results.Length - 1; i++)
                {
                    if (i % 2 == 0)
                        result = results.Substring(1);
                    else
                        result = results.Substring(0, result.Length);
                }
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
