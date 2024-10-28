using System;

class Program
{    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        Start();
    }

    static void Start()
    {
        bool exit = false;
        while (!exit)
        {
            goalManager.DisplayPlayerInfo();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");

            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                goalManager.CreateGoal();
            }
            else if (input == "2")
            {
                goalManager.ListGoalDetails();
            }
            else if (input == "3")
            {
                goalManager.SaveGoals();
            }
            else if (input == "4")
            {
                goalManager.LoadGoals();
            }
            else if (input == "5")
            {
                goalManager.RecordEvent();
            }
            else if (input == "6")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
}