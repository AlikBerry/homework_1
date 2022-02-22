using System;

namespace homework_1
{


    class Program
    {
        
        static void Main(string[] args)
        {

            string user1;
            do{
                Console.WriteLine("Please enter username 1: ");
                user1 = Console.ReadLine();
            }
            while (user1.Length <= 0);

            int age1;
            do{
                Console.WriteLine("Please enter age1: ");
                age1 = int.Parse(Console.ReadLine());
            }
            while (age1 < 0 && age1 > 100);

            string user2;
            do{
                Console.WriteLine("Please enter username 2: ");
                user2 = Console.ReadLine();
            }
            while (user2.Length <= 0);

            int age2;
            do{
                Console.WriteLine("Please enter age2: ");
                age2 = int.Parse(Console.ReadLine());
            }
            while (age2 < 0 && age2 > 100);

            if (age1 == age2)
            {
                return;
            }

            Console.WriteLine($"Who is older? {user1} or {user2}");
            Console.WriteLine("Enter name is older user: ");

            string userResponse;

            do
            {
                Console.WriteLine($"Please enter username 1 or 2: ");
                userResponse = Console.ReadLine();
            }
            while (userResponse != user1 && userResponse != user2);
                Console.WriteLine("Thanks for you choice!");

            double older;
            string check;
            if (age1 > age2)
            {
                older = age1 - age2;
                check = user1;
                if (userResponse == check)
                {
                    Console.WriteLine("Correct answer!");
                }
                else
                {
                    Console.WriteLine("Incorrect answer!!!");
                }
                
            }

            else if (age1 < age1)
            {
                check = user2;
                older = age2 - age1;
                if (userResponse == check)
                {
                    Console.WriteLine("Correct answer!");
                }
                else
                {
                    Console.WriteLine("Incorrect answer!!!");
                }
                
                Console.WriteLine($"{user2} is {older} years older than {user1}");

            }

            else
            {
                Console.WriteLine("They are peers");
            }

        }

    }
}