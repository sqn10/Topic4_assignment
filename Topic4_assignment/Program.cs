namespace Topic4_assignment
{
    internal class Program
    {
        private static string firstName;
        private static int age;
        static void Main(string[] args)
        {
            // sammy

            Part1();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Part2();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Part3();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Part4();
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Part1()
        {
            double wage;

            new Thread(() => Song()).Start();
            Typer("Hey, pal! What is your first name? \x1B[3m*beeps computer-ly*\x1B[23m ");
            firstName = Console.ReadLine();

            Console.WriteLine();

            Typer("Hello, " + firstName + "! How old are you? ");
            Int32.TryParse(Console.ReadLine(), out age);

            Console.WriteLine();

            Typer("Well, that's certainly an age... " + age + "... How much money do you make, " + firstName + "? ");
            Double.TryParse(Console.ReadLine(), out wage);

            Console.WriteLine();

            Typer(wage.ToString("C") + "! I sure hope that's hourly pal... If it's yearly, GET A NEW JOB!!!");
        }

        public static void Part2()
        {
            string lastName;
            int grade, studentNumber;
            double gradeAverage;

            Typer("Well, I want four more pieces of info from you. \u001b[1mHA HA HA!\u001b[0m I'm gonna sell them on the dark web!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Typer("I'd like your last name. What is it? ");
            lastName = Console.ReadLine();

            Console.WriteLine();

            Typer("And what grade are you in? ");
            Int32.TryParse(Console.ReadLine(), out grade);

            Console.WriteLine();

            Typer("What is your student number? ");
            Int32.TryParse(Console.ReadLine(), out  studentNumber);

            Console.WriteLine();

            Typer("Finally, what is your grade average (e.g. 80)? ");
            Double.TryParse(Console.ReadLine(), out gradeAverage);

            Console.WriteLine();
            Console.WriteLine();

            Typer("Here is your information, nicely formatted: ");

            Console.WriteLine();

            Typer("     First name:      " + firstName);
            Console.WriteLine();
            Typer("     Last name:       " + lastName);
            Console.WriteLine();
            Typer("     Age              " + age);
            Console.WriteLine();
            Typer("     Grade:           " + grade);
            Console.WriteLine();
            Typer("     Student number:  " + studentNumber);
            Console.WriteLine();
            Typer("     Log on:          " + studentNumber + "@gotvdsb.ca");
            Console.WriteLine();
            Typer("     Grade average:   " + gradeAverage + "%");
        }

        public static void Part3()
        {
            Typer("Hey " + firstName + ", did you know that you will be " + (age + 5) + " in five years?");
        }

        public static void Part4()
        {
            double num1, num2, num3, answer;

            Typer("Get prepared for the dumbest calculator... EVER! ");
            Thread.Sleep(400);
            Typer("It will ask you for three numbers, add them, and then divide them all by two. Here it goes.");

            Console.WriteLine();
            Typer("Enter the first number please: ");
            Double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine();
            Typer("Enter the second number please: ");
            Double.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine();
            Typer("Enter the third number please: ");
            Double.TryParse(Console.ReadLine(), out num3);

            Console.WriteLine();

            answer = (num1 + num2 + num3) / 2;

            Typer(num1 + " + " + num2 + " + " + num3 + " \u00F7 2 = " + Math.Round(answer, 2));
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
            Console.Beep(523, 150);
            Console.Beep(587, 150);
            Console.Beep(659, 150);
            Console.Beep(698, 150);
            Console.Beep(784, 150);
        }
    }
}
