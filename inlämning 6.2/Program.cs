using System;

class Program
{
    static void Main(string[] args)
    {
        int störstaTalet = Störst(10, 5);
        Console.WriteLine("Det största talet är: " + störstaTalet);
    }

    static int Störst(int tal1, int tal2)
    {
        if (tal1 > tal2)
        {
            return tal1;
        }
        else if (tal2 > tal1)
        {
            return tal2;
        }
        else
        {
            return tal1; 
        }
    }
}

