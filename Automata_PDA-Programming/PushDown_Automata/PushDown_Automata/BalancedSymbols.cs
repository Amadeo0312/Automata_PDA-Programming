using System.Collections;

namespace PushDown_Automata
{
    public class BalancedSymbols
    {
        public bool IsBalanced(string s)
        {
            string str = s;
            char[] symbols = str.ToCharArray();
            int length = symbols.Length;
            
            Stack stack = new Stack();

            for(int i = 0; i < length; i++)
            {   
                if(symbols[i] == '(' || symbols[i] == '[' || symbols[i] == '{')
                {
                    Console.WriteLine("Push " + symbols[i]);
                    stack.Push(symbols[i]);
                    Display(stack);
                }
                else if(stack.Count != 0 && symbols[i] == ')')
                {
                    if (Convert.ToChar(stack.Peek()) == '(')
                    {
                        Console.WriteLine("pop " + stack.Peek());
                        stack.Pop();
                        Display(stack);
                    }
                    else
                    {
                        Console.WriteLine("Pop failed. Not a Match");
                        Display(stack);
                    }
                }
                else if (stack.Count != 0 && symbols[i] == ']')
                {
                    if (Convert.ToChar(stack.Peek()) == '[')
                    {
                        Console.WriteLine("pop " + stack.Peek());
                        stack.Pop();
                        Display(stack);
                    }
                    else
                    {
                        Console.WriteLine("Pop failed. Not a Match");
                        Display(stack);
                    }
                }
                else if (stack.Count != 0 && symbols[i] == '}')
                {
                    if (Convert.ToChar(stack.Peek()) == '{')
                    {
                        Console.WriteLine("pop " + stack.Peek());
                        stack.Pop();
                        Display(stack);
                    }
                    else
                    {
                        Console.WriteLine("Pop failed. Not a Match");
                        Display(stack);
                    }
                }
                else
                {
                    if(symbols[i] == ')' || symbols[i] == ']' || symbols[i] == '}')
                        Console.WriteLine("Extra Closing Symbol\n");
                }
            }

            if (stack.Count == 0)
                return true;
            else
            {
                Console.WriteLine("Extra Opening Symbol\n");
                return false;
            }       
        }

        public void Display(Stack stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Current Stack: Empty\n");
            }
            else
            {
                Console.Write("Current Stack: ");
                foreach (var item in stack)
                {
                    Console.Write(item + " <- ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
