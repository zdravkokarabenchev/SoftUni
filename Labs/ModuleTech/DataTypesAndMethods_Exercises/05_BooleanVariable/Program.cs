using System;

public class Example
{
    public static void Main()
    {
        //input----------------------------------------------------------------
        string input = Console.ReadLine();
        //bool variable = Convert.ToBoolean(input);
        bool variable = bool.Parse(input);

        //output---------------------------------------------------------------
        if (variable)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        // Console.WriteLine(variable ? "Yes" : "No");
    }
}
