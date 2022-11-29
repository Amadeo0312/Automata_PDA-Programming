using PushDown_Automata;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Problems: ");
        Console.WriteLine("[1] - Palindromes");
        Console.WriteLine("[2] - Balanced Symbols");

        Console.Write("\nEnter a Problem Number: ");
        int prob = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter a String: ");
        var str = Console.ReadLine();
        Console.WriteLine(" ");

        switch(prob)
        {
           case 1:
                Palindromes p = new Palindromes();
                bool check = p.IsPalindrome(str);
                if (check == true)
                    Console.WriteLine("The Input \"" + str + "\" is Accepted");
                else
                    Console.WriteLine("The Input \"" + str + "\" is not Accepted");
                break;
           case 2:
                BalancedSymbols b = new BalancedSymbols();
                check = b.IsBalanced(str);
                if (check == true)
                    Console.WriteLine("The Input \"" + str + "\" is Accepted");
                else
                    Console.WriteLine("The Input \"" + str + "\" is not Accepted");
                break;
        }
    }
}