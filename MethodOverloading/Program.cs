namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = Methods.Add(5, 7);
            Console.WriteLine(answer);
            Console.WriteLine(Methods.Add(2.0, 3.1));
            Console.WriteLine(Methods.Add(2.0m, 3.1m));
            Console.WriteLine(Methods.Add(0,0,true));
        }
        



    }
}
