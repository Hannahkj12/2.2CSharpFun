using _2._2CSharpFun;
public class Program
{
    private static void Main(string[] args)
    {
        PrintStuff ps = new PrintStuff("PT");

        string name = "";

        System.Console.WriteLine("Please enter your name");
        name = System.Console.ReadLine();

        //To print John or jane doe use this code: ps.PrintName();
        ps.PrintName(name);
    }
}
