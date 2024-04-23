namespace loops_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userMin, userMax;
            Random rand = new Random();
            Console.WriteLine("This program is for randomization, it will give you 25 random numbers from lowest to highest given number");
            Console.WriteLine("Please enter a minimum number");
            userMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a maximum number");
            userMax = int.Parse(Console.ReadLine());
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(rand.Next(userMin, userMax));
               
            }
        }
    }
}