// Eternal Quest - CSE 210 Polymorphism Assignment
//
// EXCEEDING REQUIREMENTS:
// A leveling system was added as a gamification feature.
// As the player earns points, they advance through 6 levels:
// Beginner -> Apprentice -> Journeyman -> Expert -> Master -> Legend
// The current level and score needed for the next level are shown
// on the main menu. A level-up notification appears immediately
// after recording an event that triggers a level increase.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
