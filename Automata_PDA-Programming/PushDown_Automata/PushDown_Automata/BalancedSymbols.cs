using System.Collections;

namespace PushDown_Automata
{
    public class BalancedSymbols
    {   
        /// <summary>
        /// Checks if the string input is a Balanced Symbols
        /// </summary>
        /// <param name="s"> String </param>
        /// <returns> true if it is balanced, otherwise, false </returns>
        public bool IsBalanced(string s)
        {
            string str = s;
            char[] symbols = str.ToCharArray();
            int length = symbols.Length;
            
            Stack stack = new Stack();

            for(int i = 0; i < length; i++)
            {   
                // The if statement will push all opening symbols 
                if(symbols[i] == '(' || symbols[i] == '[' || symbols[i] == '{')
                {
                    Console.WriteLine("Push " + symbols[i]);
                    stack.Push(symbols[i]);
                    Display(stack);
                }
                // The else if statements will pop the stack if the top of
                // the stack is the pair of the closing symbol being read
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
                // The else statement will catch if ever the string
                // of symbols has an extra closing symbol
                else
                {
                    if(symbols[i] == ')' || symbols[i] == ']' || symbols[i] == '}')
                        Console.WriteLine("Extra Closing Symbol\n");
                }
            }

            // If the stack is Empty then it will be accepted
            if (stack.Count == 0)
                return true;
            // If the stack is not empty then it has an extra opening symbol
            else
            {
                Console.WriteLine("Extra Opening Symbol\n");
                return false;
            }       
        }

        /// <summary>
        /// This is a helper method that will display 
        /// the items of the stack every pop or push
        /// </summary>
        /// <param name="stack"> Stack </param>
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
