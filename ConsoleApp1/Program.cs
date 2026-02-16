
class Program
{
    public static void Main(string[] args)
    {
        var program = new Program();

        Console.Write("Enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            var result = program.GenerateSeries(n);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    public string GetValue(int n)
    {
        if (n % 3 == 0 && n % 5 == 0)
            return "Fizzbuzz";
        else if (n % 3 == 0)
            return "Buzz";
        else if (n % 5 == 0)
            return "Fizz";
        else
            return n.ToString();
    }

    public IEnumerable<string> GenerateSeries(int n)
    {
        for(int i= 1; i < n; i++)
            yield  return GetValue(i);
    }
}