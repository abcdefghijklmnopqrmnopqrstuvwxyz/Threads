namespace TestVlakna
{
    internal class Program
    {
        static Fronta Fronta = new();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Pridej));
            Thread thread2 = new Thread(new ThreadStart(Odeber));

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine(Fronta.ToString());
        }

        private static void Pridej()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Fronta.Vloz(random.Next(10) + 1);
            }
        }

        private static void Odeber()
        {
            for (int i = 0; i < 10; i++)
            {
                Fronta.Ziskej(0);
            }
        }

    }
}