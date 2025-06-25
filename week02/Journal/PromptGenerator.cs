using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "What made me smile today?",
            "What challenge did I overcome recently?",
            "What am I grateful for right now?",
            "Who inspired me today and why?",
            "What is one thing I want to improve about myself?"
        };
        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
