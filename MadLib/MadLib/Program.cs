public class MadLib
{
    public MadLib() { }
    public string MakeSentance(string p1, string p2, string p3, string p4, string p5)
    {
        return "Your name is " + p1 + " and your favorite color is " + p2 + ".";
    }

    static void Main(string[] args)
    {
        MadLib madLib = new MadLib();
        string name = "";
        string color = "";

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        color = Console.ReadLine();



        Console.WriteLine(madLib.MakeSentance(name, color, name, color, name));
    }
}


