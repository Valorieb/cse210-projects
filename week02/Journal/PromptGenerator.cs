public class PromptGenerator{
    private string[] _prompts = new string[] {"What made you smile today, and why?",
        "Write about a moment when you felt truly at peace.",
        "What is something you're grateful for today?",
        "Reflect on a challenge you overcame recently. How did it shape you?",
        "What’s one thing you learned today?", "What are you looking forward to this week?",
        "Describe your ideal day. What would you do?",
        "What’s one goal you want to achieve in the next month, and why?",
        "Where do you see yourself in five years?",
        "If you could try anything new without fear of failure, what would it be?", 
        "What are three things you love about yourself today?",
        "Write about a time you felt the most confident today.",
        "What do you value most in life, and why?",
        "If you could give advice to your younger self, what would it be?",
        "What does success mean to you?"};

    public string GetRandomPrompt(){
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Length);
        return _prompts[randomIndex];

    }
}