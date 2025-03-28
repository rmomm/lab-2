namespace lab2
{
    public class Factorial
    {

        public static int Fact(int n)
        {
            if (n < 0)
                throw new ArgumentException("Factorial is defined only for non-negative numbers.");

            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }

    }
    public class Program
    {
        public static int Main()
        {
            try
            {
                Console.Write("Enter number: ");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                    throw new ArgumentException("Input value cannot be empty.");

                if (!int.TryParse(input, out int number))
                    throw new FormatException("Invalid number format.");

                int result = Factorial.Fact(number);
                Console.WriteLine($"Result: {result}");
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                return 1;
            }
        }
    }
}
