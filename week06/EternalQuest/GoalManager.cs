using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    // EXTRA: Leveling system thresholds and names
    private int[] _levelThresholds = { 0, 500, 1500, 3000, 6000, 10000 };
    private string[] _levelNames    = { "Beginner", "Apprentice", "Journeyman", "Expert", "Master", "Legend" };

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // EXTRA: Returns current level based on score
    private int GetLevel()
    {
        int level = 1;
        for (int i = _levelThresholds.Length - 1; i >= 0; i--)
        {
            if (_score >= _levelThresholds[i])
            {
                level = i + 1;
                break;
            }
        }
        return level;
    }

    private string GetLevelName() => _levelNames[GetLevel() - 1];

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();

            Console.WriteLine("\n  Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("\n  Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if      (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") { Console.WriteLine("\nGoodbye!"); break; }
        }
    }

    public void DisplayPlayerInfo()
    {
        int level = GetLevel();
        int nextThreshold = level < _levelThresholds.Length ? _levelThresholds[level] : -1;
        string nextInfo = nextThreshold > 0 ? $" | Next level at {nextThreshold} pts" : " | MAX LEVEL";

        Console.WriteLine("=== Eternal Quest ===");
        Console.WriteLine($"  Score : {_score} pts");
        Console.WriteLine($"  Level : {level} - {GetLevelName()}{nextInfo}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"  {i + 1}. {_goals[i].GetName()}");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n--- Your Goals ---");
        if (_goals.Count == 0)
            Console.WriteLine("  No goals yet!");
        else
            for (int i = 0; i < _goals.Count; i++)
                Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");

        Console.Write("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n  Types of Goals:");
        Console.WriteLine("    1. Simple Goal    (complete once)");
        Console.WriteLine("    2. Eternal Goal   (never completes, always earns points)");
        Console.WriteLine("    3. Checklist Goal (complete X times + bonus)");
        Console.Write("  Select type: ");
        string type = Console.ReadLine();

        Console.Write("  Name: ");
        string name = Console.ReadLine();
        Console.Write("  Description: ");
        string desc = Console.ReadLine();
        Console.Write("  Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("  Target (how many times): ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("  Bonus points on completion: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }

        Console.WriteLine("  Goal created!");
        Console.Write("Press Enter to continue...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet! Create some first.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("\n  Which goal did you accomplish?");
        ListGoalNames();
        Console.Write("  Select: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Goal goal = _goals[index];

        if (goal.IsComplete())
        {
            Console.WriteLine("\n  This goal is already complete!");
            Console.ReadLine();
            return;
        }

        int prevLevel = GetLevel();
        goal.RecordEvent();

        int earned = goal.GetPoints();

        if (goal is ChecklistGoal cg)
        {
            int bonus = cg.GetBonusPoints();
            if (bonus > 0)
            {
                earned += bonus;
                Console.WriteLine($"\n  Checklist complete! Bonus: +{bonus} pts");
            }
        }

        _score += earned;
        Console.WriteLine($"\n  You earned {earned} points! Total: {_score}");

        // EXTRA: Notify when player levels up
        if (GetLevel() > prevLevel)
            Console.WriteLine($"\n  *** LEVEL UP! You are now Level {GetLevel()} - {GetLevelName()} ***");

        Console.Write("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void SaveGoals()
    {
        Console.Write("  Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }

        Console.WriteLine("  Saved!");
        Console.ReadLine();
    }

    public void LoadGoals()
    {
        Console.Write("  Filename: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("  File not found!");
            Console.ReadLine();
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] p = lines[i].Split(',');
            if (p[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(p[1], p[2], int.Parse(p[3]), bool.Parse(p[4])));
            else if (p[0] == "EternalGoal")
                _goals.Add(new EternalGoal(p[1], p[2], int.Parse(p[3])));
            else if (p[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(p[1], p[2], int.Parse(p[3]),
                    int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[6])));
        }

        Console.WriteLine("  Loaded!");
        Console.ReadLine();
    }
}
