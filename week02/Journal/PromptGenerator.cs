using System;
using System.Security.Cryptography.X509Certificates;


class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "Describe a challenge you overcame.",
        "What are you grateful for?",
        "Write about a moment of peace.",
        "How did you help someone today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
    