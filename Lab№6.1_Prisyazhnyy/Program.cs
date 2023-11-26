//сборник задач/тема 6/подтема 6.1/высокий уровень/вариант 2
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите x(x>=0): ");
            double x = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Random random = new Random();
                    int n = random.Next(-10, 10);
                    Console.WriteLine($"x в степени {i}-ого значения (n = {n}) = {PowerN(x, n):F2}");
                }
            }
            else Console.WriteLine("x не подходит по условию");
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        double PowerN(double x, int n)
        {
        if (n > 0)
            return x * Math.Pow(x, n-1);
        if (n < 0)
            return 1 / Math.Pow(x,n);
        else
            return 1;
        }
    }
}