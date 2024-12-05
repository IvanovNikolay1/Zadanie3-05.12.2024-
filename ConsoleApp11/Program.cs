namespace ConsoleApp11
{
    internal class Program
    {
        public static int DigitalRoot(int num)
        {
            if (num < 10)
            {
                return num;
            }

            int sum = 0;

            while (num >= 10)
            {
                sum += num % 10;
                num /= 10;
            }
            return DigitalRoot(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчета цифрового корня: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                int result = DigitalRoot(num);
                Console.WriteLine($"Цифровой корень числа {num} равне {result}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введено не коректное число.");
            }
        }
    }
}
