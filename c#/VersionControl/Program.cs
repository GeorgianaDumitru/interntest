using System;
using System.Text.RegularExpressions;

class VersionControl
{
    static void Main()
    {        
        Console.WriteLine("Enter Version");
         
        string name;
        name = Console.ReadLine();

        string[] operands = Regex.Split(name, @"\.");

            Console.WriteLine("Major:" + operands[0]);
            Console.WriteLine("Minor:" + operands[1]);
            Console.WriteLine("Bugfix:" + operands[2]);
        
    }
}