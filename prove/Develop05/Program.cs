using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.Clear();
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathingg in and out slowly. Clear your mind and focus on your breathing.");
            }
            else if (userChoice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            }
            else if (userChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
            else if (userChoice == 4)
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please choose a number from 1-4.");
                Console.Clear();
            }
        }
    }
}