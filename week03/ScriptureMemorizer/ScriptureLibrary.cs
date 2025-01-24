public class ScriptureLibrary {
    private Reference scrip1;
    private Reference scrip2;
    private Reference scrip3;
    private Reference scrip4;
    private Reference scrip5;


    private List<Scripture> scriptureLibrary;

    public ScriptureLibrary()
    {
        Reference scrip1 = new Reference("John", 3, 5);
        Reference scrip2 = new Reference("Matthew", 5, 14, 16);
        Reference scrip3 = new Reference("2 Nephi", 2, 25);
        Reference scrip4 = new Reference("Moroni", 10, 4, 5);
        Reference scrip5 = new Reference("3 Nephi",27,27);

        scriptureLibrary = new List<Scripture>
        {
            new Scripture(scrip1, "Jesus answered, Verily, verily, I say unto thee,Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God."),
            new Scripture(scrip2, "Ye are the light of the world. A city that is set on an hill cannot be hid.Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house.Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven."),
            new Scripture(scrip3, "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(scrip4, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."),
            new Scripture(scrip5, "And know ye that ye shall be judges of this people, according to the judgment which I shall give unto you, which shall be just. Therefore, what manner of men ought ye to be? Verily I say unto you, even as I am."),
        };
    }
    public Scripture GetRandomScripture(){

        Random random = new Random();
        return scriptureLibrary[random.Next(scriptureLibrary.Count)];
    }


    public void AddScripture(Scripture scripture)
    {
        scriptureLibrary.Add(scripture);
    }

    public int GetScriptureCount()
    {
        return scriptureLibrary.Count;
    }
}