namespace Topic4_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sammy
            Part1();
        }

        public static void Part1()
        {
            string personName;
            int age;
            double wage;

            new Thread(() => Song()).Start();
            Typer("Hey, pal! What is your name \x1B[3m*beeps computer-ly*\x1B[23m ");
            personName = Console.ReadLine();

            Console.WriteLine();

            Typer("Hello, " + personName + "! How old are you? ");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine();

            Typer("Well, that's certainly an age... How much do you make, " + personName + "? ");
            Double.TryParse(Console.ReadLine(), out wage);

            Console.WriteLine();

            Typer(wage.ToString("C") + "! I sure hope that's hourly pal... If it's yearly, GET A NEW JOB!!!");

            // finish the rest of the assignment!!!
        }
        public static void Typer(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(20);
            }
        }
        public static void Song()
        {
            Console.Beep(800, 150);
            Console.Beep(900, 150);
            Console.Beep(1000, 150);
            Console.Beep(1050, 150);
            Console.Beep(1200, 150);
        }
    }
}
