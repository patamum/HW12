namespace Task12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату точки x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату точки y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату центра x0: ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату центра y: ");            
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double lenth = Circle.GetLenthCircle(r);
            double square = Circle.GetSquareCircle(r);
            Console.WriteLine($"длина окружности = {square:.00} \nплощадь окружности = {square:.00}");
            Console.WriteLine(Circle.InCircle(x, y, r, x0, y0));

        }
    }
}