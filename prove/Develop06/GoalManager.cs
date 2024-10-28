using System;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].ShortName}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine();
        
        for (int i = 0; i < goals.Count; i++)
        {
            if (goals[i] is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i + 1}. {checklistGoal.GetStringRepresentation()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStringRepresentation()}");
            }
        }
        
    }
    public void CreateGoal()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.WriteLine("   4. Return to main menu");
            Console.WriteLine("Which type of goal would you like to create? ");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine();
                Console.Write("What is the name of your goal? ");
                string shortName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new SimpleGoal(shortName, description, points);
                goals.Add(goal);

                break;
            }
            else if (input == "2")
            {
                Console.WriteLine();
                Console.Write("What is the name of your goal? ");
                string shortName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Goal goal = new EternalGoal(shortName, description, points);
                goals.Add(goal);

                break;
            }
            else if (input == "3")
            {
                Console.WriteLine();
                Console.Write("What is the name of your goal? ");
                string shortName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                Goal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                goals.Add(goal);

                break;
            }
            else if (input == "4")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine();
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            Goal selectedGoal = goals[index];
            selectedGoal.RecordEvent();
            _score += selectedGoal.Points;
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Please choose a valid goal.");
        }
    }
    public void SaveGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_score);

            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"SimpleGoal|{simpleGoal.ShortName}|{simpleGoal.Description}|{simpleGoal.Points}|{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"EternalGoal|{eternalGoal.ShortName}|{eternalGoal.Description}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal|{checklistGoal.ShortName}|{checklistGoal.Description}|{checklistGoal.Points}|{checklistGoal.Bonus}|{checklistGoal.Target}|{checklistGoal.AmountCompleted}");
                }
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine();
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);

        Console.WriteLine();

        goals.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];

                Goal goal = null;
                if (goalType == nameof(SimpleGoal) && parts.Length == 5)
                {
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);
                    goal = new SimpleGoal(shortName, description, points);
                    if (isComplete) goal.RecordEvent();
                }
                else if (goalType == nameof(EternalGoal) && parts.Length == 4)
                {
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    goal = new EternalGoal(shortName, description, points);
                }
                else if (goalType == nameof(ChecklistGoal) && parts.Length == 7)
                {
                    string shortName = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int amountCompleted = int.Parse(parts[6]);
                    goal = new ChecklistGoal(shortName, description, points, target, bonus);
                    for (int i = 0; i < amountCompleted; i++) goal.RecordEvent();
                }

                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }

        Console.WriteLine("Goals and total points loaded successfully.");
    }
}